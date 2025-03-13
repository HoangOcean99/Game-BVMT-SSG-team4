using UnityEngine;
using UnityEngine.UI;

public class ControllerUI : MonoBehaviour
{
    public string currentScene;
    public string NameMini1;
    public string NameMini2;
    public Button button_panelMini1;
    public Button button_panelMini2;

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
        });
        button_panelMini2.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.HideScene(currentScene);
            LoadSceneManager.LoadNewScene(NameMini2);
        });
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
