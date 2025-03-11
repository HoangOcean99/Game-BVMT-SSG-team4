using UnityEngine;
using UnityEngine.UI;

public class ControllerUIMap2 : MonoBehaviour
{
    public Button buttonTiep;
    public Button buttonXacNhan;
    public GameObject panelIntro1;
    public GameObject panelIntro2;
    public GameObject panelMain;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;
        buttonTiep.onClick.AddListener(() =>
        {
            panelIntro1.SetActive(false);
            panelIntro2.SetActive(true);
        });
        buttonXacNhan.onClick.AddListener(() =>
        {
            panelMain.SetActive(false);
            panelIntro2.SetActive(false);
            Time.timeScale = 1;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
