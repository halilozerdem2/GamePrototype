using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour
{
    public TaskManager taskManager;  // TaskManager referans�
    public Text taskListText;  // UI Text objesi

    // Bu metod, sahne ad�na g�re g�rev listesini g�nceller
    public void UpdateTaskList(string sceneName)
    {
        List<Task> tasksForScene = taskManager.GetTasksForScene(sceneName);  // Sahneye �zel g�revler
        taskListText.text = "";  // �nceki listeyi temizle

        foreach (Task task in tasksForScene)
        {
            string status = task.isCompleted ? "Tamamland�" : "Devam Ediyor";
            taskListText.text += $"{task.taskName} - {status}\n";  // G�rev ad�n� ve durumunu listele
        }
    }
}
