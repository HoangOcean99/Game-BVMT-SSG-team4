using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickButtonINtro : MonoBehaviour
{
    public Button buttonChoi;
    public Button buttonCachChoi;
    public Button buttonThoat;
    public Button buttonBoy; 
    public Button buttonGirl;
    public Button buttonSetting;
    public Button buttonReturnSetting;

    public TMP_InputField textName;
    public GameObject panelMenuMain;
    public GameObject panelCachChoi;
    public GameObject panelSetting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonCachChoi.onClick.AddListener(() =>{
            panelCachChoi.SetActive(true);
            panelMenuMain.SetActive(false);
        });
        buttonThoat.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        buttonChoi.onClick.AddListener(() => { 
            if(textName.text.Length > 0)
            {
                SceneManager.LoadScene("ThiTranScene");
            }
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
