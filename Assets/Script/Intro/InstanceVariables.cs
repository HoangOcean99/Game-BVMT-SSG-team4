using System;
using UnityEngine;

public class InstanceVariables : MonoBehaviour
{
    public static InstanceVariables Instance { get; private set; }
    public int point = 0;
    public string nameUser = "";
    public Boolean OptionPlayer = true;
    public Boolean music = true;
    public Boolean sound = true;

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
