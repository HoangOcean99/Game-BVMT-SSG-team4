using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGioiThieuThungRac : MonoBehaviour
{
    public GameObject panelThungRacHuuCo;
    public GameObject panelThungRacVoCo;
    public GameObject panelThungRacTaiChe;
    public Button bt_huuCo;
    public Button bt_voCo;
    public Button bt_taiChe;
    public Button bt_dongHuuCo;
    public Button bt_dongVoCo;
    public Button bt_dongTaiChe;

    public GameObject panelIntroFirst;
    public Button buttonConfirmIntroFirst;


    public AudioSource audioClickButton;
    private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            instanceGeneral = FindAnyObjectByType<InstanceVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        bt_huuCo.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacHuuCo.SetActive(true);
        });
        bt_voCo.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacVoCo.SetActive(true);
        });
        bt_taiChe.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacTaiChe.SetActive(true);
        });


        bt_dongHuuCo.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacHuuCo.SetActive(false);
        });
        bt_dongVoCo.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacVoCo.SetActive(false);
        });
        bt_dongTaiChe.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelThungRacTaiChe.SetActive(false);
        });
        buttonConfirmIntroFirst.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelIntroFirst.SetActive(false);
        });

        
    }
}
