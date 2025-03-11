using UnityEngine;

public class instancePointMini1map2 : MonoBehaviour
{
    public static instancePointMini1map2 Instance { get; private set; }
    public int point = 0;

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
