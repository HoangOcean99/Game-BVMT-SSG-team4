using UnityEngine;

public class InstanceVariableMap2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static InstanceVariableMap2 Instance { get; private set; }
    public int objectMini1 = 0;
    public int objectMini2 = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Xóa instance trùng lặp
        }
    }
    public void DestroyInstance()
    {
        Destroy(gameObject);
        Instance = null;
    }
}
