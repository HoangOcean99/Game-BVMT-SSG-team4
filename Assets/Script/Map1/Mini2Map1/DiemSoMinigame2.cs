using UnityEngine;

public class DiemSoMinigame2 : MonoBehaviour
{
    public static DiemSoMinigame2 Instance { get; private set; }
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
}
