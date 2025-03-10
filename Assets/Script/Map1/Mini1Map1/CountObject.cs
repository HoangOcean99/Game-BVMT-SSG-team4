using UnityEngine;

public class CountObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static CountObject Instance { get; private set; }
    public int count = 0;

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
