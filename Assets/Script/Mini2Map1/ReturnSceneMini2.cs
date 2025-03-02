using UnityEngine;
using UnityEngine.UI;

public class ReturnSceneMini2 : MonoBehaviour
{
    public Button button_returnScene;
    public string sceneHome;
    public string sceneCurrent;

    //private InstaceObjectMinigam1 miniGame1;
    void Start()
    {
        //miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
    }

    // Update is called once per frame
    void Update()
    {
        button_returnScene.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            //miniGame1.change = 1;
        });


    }
}
