using UnityEngine;
using UnityEngine.UI;

public class ControllerUI : MonoBehaviour
{
    public string currentScene;
    public string NameMini1;
    public Button button_panelMini1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button_panelMini1.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.HideScene(currentScene);
            LoadSceneManager.LoadNewScene(NameMini1);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
        });
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
