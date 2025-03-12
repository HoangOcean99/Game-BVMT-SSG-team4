using UnityEngine;

public class InstanceChangeMap3 : MonoBehaviour
{
    public static InstanceChangeMap3 Instance { get; private set; }
    public int mini1 = 0;
    public int mini2 = 0;

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
