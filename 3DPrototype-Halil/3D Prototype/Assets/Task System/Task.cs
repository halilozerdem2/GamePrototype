[System.Serializable]
public class Task
{
    public string taskName;  // G�rev ad�
    public string description;  // G�rev a��klamas�
    public bool isCompleted;  // G�rev tamamland� m�?
    public string sceneName;  // G�revin ba�l� oldu�u sahne

    public Task(string name, string desc, string scene)
    {
        taskName = name;
        description = desc;
        isCompleted = false;
        sceneName = scene;
    }
}
