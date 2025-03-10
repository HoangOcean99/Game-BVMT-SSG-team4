using UnityEngine;

public class InstanceQuestionFinish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static InstanceQuestionFinish Instance { get; private set; }
    public int countFinish = 0;

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
