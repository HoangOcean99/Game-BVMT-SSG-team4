using UnityEngine;
using UnityEngine.UI;

public class ControllerUI : MonoBehaviour
{
    public string currentScene;
    public string NameMini1;
    public string NameMini2;
    public Button button_panelMini1;
    public Button button_panelMini2;
    public AudioSource audioClickButton;

    private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioClickButton.time = 0f;
        audioClickButton.pitch = 1.2f;
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        button_panelMini1.onClick.AddListener(() =>
        {
            instanceGeneral.move = true;
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.HideScene(currentScene);
            LoadSceneManager.LoadNewScene(NameMini1);
            LoadSceneManager.DisableExtraAudioListeners();
        });
        button_panelMini2.onClick.AddListener(() =>
        {
            instanceGeneral.move = true;
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
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
