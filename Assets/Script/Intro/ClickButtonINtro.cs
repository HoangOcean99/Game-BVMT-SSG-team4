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
    

    private InstanceVariables instanceVariableGeneral;
    private ChangeOpacity opacity;
    private CreateNotification notification;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        opacity = FindAnyObjectByType<ChangeOpacity>();
        instanceVariableGeneral = FindAnyObjectByType<InstanceVariables>();
        notification = FindAnyObjectByType<CreateNotification>();

        buttonCachChoi.onClick.AddListener(() =>{
            panelCachChoi.SetActive(true);
            panelMenuMain.SetActive(false);
        });
        buttonReturnSetting.onClick.AddListener(() => {
            panelCachChoi.SetActive(false);
            panelMenuMain.SetActive(true);
        });
        buttonThoat.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        buttonChoi.onClick.AddListener(() => {
            if (textName.text.Length > 0)
            {
                instanceVariableGeneral.nameUser = textName.text;
                SceneManager.LoadScene("ThiTranScene");
            }
            else notification.ShowNotification();

        });
       
        buttonBoy.onClick.AddListener(() =>
        {
            instanceVariableGeneral.OptionPlayer = true;
            opacity.ActivateButton1();
        });
        buttonGirl.onClick.AddListener(() =>
        {
            instanceVariableGeneral.OptionPlayer = false;
            opacity.ActivateButton2();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
