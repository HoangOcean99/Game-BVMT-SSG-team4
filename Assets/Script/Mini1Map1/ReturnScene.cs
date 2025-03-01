using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnScene : MonoBehaviour
{
    public Button button_returnScene;
    public string sceneHome;
    public string sceneCurrent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        button_returnScene.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
        });


    }
}
