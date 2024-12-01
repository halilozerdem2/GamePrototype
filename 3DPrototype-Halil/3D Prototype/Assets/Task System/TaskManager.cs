using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public List<Task> tasks = new List<Task>();  // T�m g�revlerin listesi

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void CompleteTask(string taskName)
    {
        Task task = tasks.Find(t => t.taskName == taskName);
        if (task != null)
        {
            task.isCompleted = true;
            Debug.Log($"G�rev tamamland�: {taskName}");
        }
    }

    public List<Task> GetTasksForScene(string sceneName)
    {
        return tasks.FindAll(t => t.sceneName == sceneName);
    }
}
