using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public TaskManager taskManager;
    public TaskUI taskUI; // TaskUI referans�

    void Start()
    {
        // G�rev tan�mlar�
        taskManager.AddTask(new Task("Anahtar Bul", "Ev kap�s�n� a�mak i�in anahtar� bul.", "Game"));
        taskManager.AddTask(new Task("K�pr�den Ge�", "K�pr�deki engeli kald�r ve ge�.", "Level1"));
        taskManager.AddTask(new Task("Kap�y� A�", "Ev kap�s�n� anahtar ile a�.", "level2"));

        // InputManager'dan OnTaskPressed olay�n� dinle
        InputManager.Instance.OnTaskPressed += UpdateTaskList;
    }

    private void OnDestroy()
    {
        // Olay aboneli�ini kald�r
        if (InputManager.Instance != null)
        {
            InputManager.Instance.OnTaskPressed -= UpdateTaskList;
        }
    }

    void UpdateTaskList()
    {
        // TaskUI varsa g�rev listesini g�ncelle
        if (taskUI != null)
        {
            taskUI.UpdateTaskList("Game");
        }
        else
        {
            Debug.LogWarning("TaskUI referans� atanmad�!");
        }
    }
}
