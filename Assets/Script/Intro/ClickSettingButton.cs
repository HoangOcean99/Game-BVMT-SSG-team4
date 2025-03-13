using UnityEngine;
using UnityEngine.UI;

public class ClickSettingButton : MonoBehaviour
{
    public Button buttonSetting;
    public GameObject panelSetting;

    public Button turnOffMusic;
    public Button turnOnMusic;
    public Button turnOffSound;
    public Button turnOnSound;

    public AudioSource audioClickButton;

    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioClickButton.time = 0f;
        audioClickButton.pitch = 1.2f;
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        buttonSetting.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            if (panelSetting.active)
            {
                panelSetting.SetActive(false);
            }
            else
            {
                panelSetting.SetActive(true);
            }
        });
        turnOnMusic.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            turnOnMusic.gameObject.SetActive(false);
            turnOffMusic.gameObject.SetActive(true);
            instanceGeneral.music = false;
        });
        turnOffMusic.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            turnOffMusic.gameObject.SetActive(false);
            turnOnMusic.gameObject.SetActive(true);
            instanceGeneral.music = true;
        });
        turnOffSound.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            turnOffSound.gameObject.SetActive(false);
            turnOnSound.gameObject.SetActive(true);
            instanceGeneral.sound = true;
        });
        turnOnSound.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            turnOnSound.gameObject.SetActive(false);
            turnOffSound.gameObject.SetActive(true);
            instanceGeneral.sound = false;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
