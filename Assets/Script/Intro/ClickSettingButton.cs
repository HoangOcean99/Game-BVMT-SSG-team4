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

    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        buttonSetting.onClick.AddListener(() =>
        {
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
            turnOffMusic.gameObject.SetActive(true);
            turnOnMusic.gameObject.SetActive(false);
            instanceGeneral.music = false;
        });
        turnOffMusic.onClick.AddListener(() =>
        {
            
            turnOffMusic.gameObject.SetActive(false);
            turnOnMusic.gameObject.SetActive(true);
            instanceGeneral.music = true;
        });
        turnOffSound.onClick.AddListener(() =>
        {
            turnOffSound.gameObject.SetActive(false);
            turnOnSound.gameObject.SetActive(true);
            instanceGeneral.sound = true;
        });
        turnOnSound.onClick.AddListener(() =>
        {
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
