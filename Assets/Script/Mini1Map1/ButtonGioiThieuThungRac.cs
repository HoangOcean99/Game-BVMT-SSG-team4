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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bt_huuCo.onClick.AddListener(() =>
        {
            panelThungRacHuuCo.SetActive(true);
        });
        bt_voCo.onClick.AddListener(() =>
        {
            panelThungRacVoCo.SetActive(true);
        });
        bt_taiChe.onClick.AddListener(() =>
        {
            panelThungRacTaiChe.SetActive(true);
        });


        bt_dongHuuCo.onClick.AddListener(() =>
        {
            panelThungRacHuuCo.SetActive(false);
        });
        bt_dongVoCo.onClick.AddListener(() =>
        {
            panelThungRacVoCo.SetActive(false);
        });
        bt_dongTaiChe.onClick.AddListener(() =>
        {
            panelThungRacTaiChe.SetActive(false);
        });
    }
}
