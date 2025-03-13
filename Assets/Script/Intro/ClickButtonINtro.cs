using System;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickButtonINtro : MonoBehaviour
{
    public Button buttonChoi;
    public Button buttonCachChoi;
    public Button buttonThoat;
    public Button buttonBoy; 
    public Button buttonGirl;
    public Button buttonReturnSetting;

    public TMP_InputField textName;
    public GameObject panelMenuMain;
    public GameObject panelCachChoi;

    public AudioSource audioClickButton;

    private InstanceVariables instanceVariableGeneral;
    private ChangeOpacity opacity;
    private CreateNotification notification;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioClickButton.time = 0f;
        audioClickButton.pitch = 1.2f;
        opacity = FindAnyObjectByType<ChangeOpacity>();
        instanceVariableGeneral = FindAnyObjectByType<InstanceVariables>();
        notification = FindAnyObjectByType<CreateNotification>();
    
        buttonCachChoi.onClick.AddListener(() =>{
            if (instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelCachChoi.SetActive(true);
            panelMenuMain.SetActive(false);
        });
        buttonReturnSetting.onClick.AddListener(() => {
            if (instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelCachChoi.SetActive(false);
            panelMenuMain.SetActive(true);
        });
        buttonThoat.onClick.AddListener(() =>
        {
            if (instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            Application.Quit();
        });
        buttonChoi.onClick.AddListener(() => {
            if (textName.text.Length > 0)
            {
                if (instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
                instanceVariableGeneral.nameUser = textName.text;
                SceneManager.LoadScene("ThiTranScene");
            }
            else notification.ShowNotification();

        });
       
        buttonBoy.onClick.AddListener(() =>
        {
            if (instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            instanceVariableGeneral.OptionPlayer = true;
            opacity.ActivateButton1();
        });
        buttonGirl.onClick.AddListener(() =>
        {
            if(instanceVariableGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            instanceVariableGeneral.OptionPlayer = false;
            opacity.ActivateButton2();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
