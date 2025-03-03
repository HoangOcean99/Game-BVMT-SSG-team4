using UnityEngine;

public class InstaceObjectMinigame2 : MonoBehaviour
{
    public static InstaceObjectMinigame2 Instance { get; private set; }
    public int change = 0;

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