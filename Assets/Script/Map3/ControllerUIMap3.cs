using UnityEngine;
using UnityEngine.UI;

public class ControllerUIMap3 : MonoBehaviour
{
    public Button buttonTiep;
    public Button buttonXacNhan;
    public GameObject panelIntro1;
    public GameObject panelIntro2;
    public GameObject panelMain;

    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        Time.timeScale = 0;
        buttonTiep.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelIntro1.SetActive(false);
            panelIntro2.SetActive(true);
        });
        buttonXacNhan.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
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
