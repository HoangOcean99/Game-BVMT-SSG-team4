using UnityEngine;

public class TinhDiemMiniGame1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static TinhDiemMiniGame1 Instance { get; private set; }
    public int diem = 0;

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
}
