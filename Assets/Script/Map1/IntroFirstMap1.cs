using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntroFirstMap1 : MonoBehaviour
{
    public TextMeshProUGUI textIntro1;
    public TextMeshProUGUI textIntro2;
    public Button buttonTiep;
    public Button buttonXacNhan;
    public GameObject panelIntro1;
    public GameObject panelIntro2;
    public GameObject panelMain;

    private InstanceVariables instanceVariable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;
        instanceVariable = FindAnyObjectByType<InstanceVariables>();
        textIntro1.text = "Xin chào kĩ sư môi trường " + instanceVariable.nameUser + ", thành phố của bạn đang bị ô nhiễm rất trầm trọng, người dân đã di tản. <sprite=2>";
        textIntro2.text = "Nhiệm vụ của bạn là hoàn thành các minigame và câu hỏi để mang lại sự trong lành và bình yên cho thành phố. <sprite=3>";

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
