using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private UIManager uiManager;
    private SceneLoader loader;
    private bool isEscapeHandled = false;
    public TaskManager taskManager;

    public Scene currentScene;    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        taskManager = GetComponentInChildren<TaskManager>();
        uiManager=GetComponentInChildren<UIManager>();

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        if (uiManager == null)
        {
            Debug.LogError("UIManager not found in the scene!");
        }

        InputManager.Instance.OnPausePressed += HandlePauseToggle;
        InputManager.Instance.OnTaskPressed += uiManager.ToggleTaskPanel;
        InputManager.Instance.OnInventoryPressed += uiManager.ToggleInventoryPanel;

    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        currentScene = scene;
        // Sahne yüklendiğinde yapılacak işlemler
        switch (scene.name)
        {
            case "Morning" :
                PlayerSpawner.Instance.DisablePlayer();
                PlayerSpawner.Instance.SpawnCharacter();
                PlayGame();
                Debug.Log("morning");
                taskManager.Tasks.Clear();
                taskManager.AddTask(new Task("Çöp At", "Alt kattaki çöpü bul ve konteynıra at"));
                
                break;
            case "Night":
                PlayerSpawner.Instance.DisablePlayer();
                PlayerSpawner.Instance.SpawnCharacter();
                PlayGame();
                taskManager.Tasks.Clear();
                taskManager.AddTask(new Task("Antidepresan zamanı", "Evdeki ilacını ve suyu bul ve Q ya basarak kullan"));
                
                break;
            case "MainMenu":
                PlayerSpawner.Instance.DisablePlayer();
                Debug.Log("mainmenu");
                PauseGame();
                taskManager.Tasks.Clear();
                break;
            case "GamOver":
                PlayerSpawner.Instance.DisablePlayer();
                PauseGame();
                taskManager.Tasks.Clear();
                
            break;

        }
    }

   
    private void HandlePauseToggle()
    {
        PauseGame();
        uiManager.ShowPauseMenu();
 
    }
    
    public void PlayGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        InputManager.Instance.EnablePlayerInput();
        InputManager.Instance.EnableUIInputs();
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        InputManager.Instance.DisablePlayerInput();
        InputManager.Instance.DisableUIInputs();
        Time.timeScale = 0f;
    }
    

    private void Update()
    {
        HandleInput();
        currentScene = SceneManager.GetActiveScene();
    }

    private void HandleInput()
    {
        if (InputManager.Instance.isEscapedPressed)
        {
            if (!isEscapeHandled)
            {
                isEscapeHandled = true;

                PauseGame();
                uiManager.ShowPauseMenu();
            }
            else
            {
                isEscapeHandled = false;
            }
        }
        if (InputManager.Instance.isTButtonPressed)
            uiManager.ToggleTaskPanel();

        if (InputManager.Instance.isIButtonPressed)
            uiManager.ToggleInventoryPanel();
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }
    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if (asyncLoad.progress >= 0.9f)
            {
                asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Sahne yüklendiğinde çağrılan olayı temizle
    }
}
