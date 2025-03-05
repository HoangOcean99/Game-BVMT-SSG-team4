using UnityEngine;
using UnityEngine.UI;

public class ReturnSceneMini2 : MonoBehaviour
{
    public Button button_returnScene;
    public string sceneHome;
    public string sceneCurrent;

    private InstaceObjectMinigame2 miniGame2;
    void Start()
    {
        miniGame2 = FindAnyObjectByType<InstaceObjectMinigame2>();
        button_returnScene.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            Time.timeScale = 1;
            checkMainPlayer();
            miniGame2.change = 1;
        });
    }

    // Update is called once per frame  
    void Update()
    {
        
    }
    public void checkMainPlayer()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length > 1)
        {
            // Nếu có hơn 1 mainPlayer, xóa bớt 1 cái
            for (int i = 1; i < players.Length; i++)
            {
                Destroy(players[i]);
            }
        }
    }
}
