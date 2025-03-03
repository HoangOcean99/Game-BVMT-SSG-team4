using UnityEngine;

public class InstaceObjectMinigam1 : MonoBehaviour
{
    public static InstaceObjectMinigam1 Instance { get; private set; }
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