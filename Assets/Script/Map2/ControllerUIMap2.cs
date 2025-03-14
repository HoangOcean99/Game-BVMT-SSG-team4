using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControllerUIMap2 : MonoBehaviour
{
    public Button buttonTiep;
    public Button buttonXacNhan;
    public GameObject panelIntro1;
    public GameObject panelIntro2;
    public GameObject panelMain;

    public AudioSource audioClickButton;

    public TextMeshProUGUI textIntro1;
    public TextMeshProUGUI textIntro2;
    public AudioSource audioTypeWritting;


    private InstanceVariables instanceGeneral;
    private string fullText;
    public float typingSpeed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceGeneral.move = false;
        fullText = textIntro1.text;
        textIntro1.text = "";
        StartCoroutine(ShowText(textIntro1));
        buttonTiep.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            audioTypeWritting.Pause();
            panelIntro1.SetActive(false);
            panelIntro2.SetActive(true);
            fullText = textIntro2.text;
            textIntro2.text = "";
            StartCoroutine(ShowText(textIntro2));
        });
        buttonXacNhan.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            audioTypeWritting.Pause();
            panelMain.SetActive(false);
            panelIntro2.SetActive(false);
            instanceGeneral.move = true;
        });
    }
    IEnumerator ShowText(TextMeshProUGUI text)
    {
        if (instanceGeneral.sound) audioTypeWritting.Play();
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
