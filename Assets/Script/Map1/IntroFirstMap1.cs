using System.Collections;
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
    public AudioSource audioClickButton;
    public AudioSource audioTypeWritting;

    public float typingSpeed = 0.05f;

    private string fullText;

    private InstanceVariables instanceVariable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceVariable = FindAnyObjectByType<InstanceVariables>();

        audioClickButton.time = 0f;
        audioClickButton.pitch = 1.2f;
        //Time.timeScale = 0;
        instanceVariable.move = false;
        textIntro1.text = "Xin chào kĩ sư môi trường " + instanceVariable.nameUser + ", thành phố của bạn đang bị ô nhiễm rất trầm trọng, người dân đã di tản. <sprite=2>";
        textIntro2.text = "Nhiệm vụ của bạn là hoàn thành các minigame và câu hỏi để mang lại sự trong lành và bình yên cho thành phố. <sprite=3>";

        fullText = textIntro1.text;
        textIntro1.text = "";
        StartCoroutine(ShowText(textIntro1));

        buttonTiep.onClick.AddListener(() =>
        {
            if (instanceVariable.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            audioTypeWritting.Pause();
            panelIntro1.SetActive(false);
            panelIntro2.SetActive(true);
            fullText = textIntro2.text;
            textIntro2.text = "";
            StartCoroutine(ShowText(textIntro2));
        });
        buttonXacNhan.onClick.AddListener(() =>
        {
            if (instanceVariable.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            audioTypeWritting.Pause();
            panelMain.SetActive(false);
            panelIntro2.SetActive(false);
            //Time.timeScale = 1;
            instanceVariable.move = true;
        });
    }
    IEnumerator ShowText(TextMeshProUGUI text)
    {
        if (instanceVariable.sound) audioTypeWritting.Play();
        for (int i = 0; i < fullText.Length; i++)
        {
            text.text += fullText[i];
            yield return new WaitForSeconds(typingSpeed);
        }
        audioTypeWritting.Pause();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
