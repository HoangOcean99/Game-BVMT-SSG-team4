using System.Collections;
using TMPro;
using UnityEngine;

public class ChallengeAppear : MonoBehaviour
{

    public GameObject panel_miniGame1;
    public GameObject panel_miniGame2;

    public GameObject panel_question1;
    public GameObject panel_question2;
    public GameObject panel_question3;
    public GameObject panel_question4;
    public GameObject panel_question5;
    public GameObject panel_question6;
    public GameObject panel_question7;
    public GameObject panel_question8;
    public TextMeshProUGUI textMini1;
    public TextMeshProUGUI textMini2;
    public AudioSource audioTypeWritting;
    public CanvasGroup canvasQUestion1;
    public CanvasGroup canvasQUestion2;
    public CanvasGroup canvasQUestion3;
    public CanvasGroup canvasQUestion4;
    public CanvasGroup canvasQUestion5;
    public CanvasGroup canvasQUestion6;
    public CanvasGroup canvasQUestion7;
    public CanvasGroup canvasQUestion8;



    public float typingSpeed = 0.05f;

    private string fullText;


    public GameObject miniMap;

    public HieuUngCanvas hieuUng;

    private InstanceVariables instanceGeneral;
    private void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Minigame1")
        {
            instanceGeneral.move = false;
            panel_miniGame1.SetActive(true);
            fullText = textMini1.text;
            textMini1.text = "";
            StartCoroutine(ShowText(textMini1));
        }
        if (collision.gameObject.tag == "Minigame2")
        {
            instanceGeneral.move = false;
            panel_miniGame2.SetActive(true);
            fullText = textMini2.text;
            textMini2.text = "";
            StartCoroutine(ShowText(textMini2));
        }
        if (collision.gameObject.tag == "Question1")
        {
            miniMap.SetActive(false);
            panel_question1.SetActive(true);
            hieuUng.FadeIn(canvasQUestion1);
        }
        if (collision.gameObject.tag == "Question2")
        {
            miniMap.SetActive(false);
            panel_question2.SetActive(true);
            hieuUng.FadeIn(canvasQUestion2);
        }
        if (collision.gameObject.tag == "Question3")
        {
            miniMap.SetActive(false);
            panel_question3.SetActive(true);
            hieuUng.FadeIn(canvasQUestion3);
        }
        if (collision.gameObject.tag == "Question4")
        {
            miniMap.SetActive(false);
            panel_question4.SetActive(true);
            hieuUng.FadeIn(canvasQUestion4);
        }
        if (collision.gameObject.tag == "Question5")
        {
            miniMap.SetActive(false);
            panel_question5.SetActive(true);
            hieuUng.FadeIn(canvasQUestion5);
        }
        if (collision.gameObject.tag == "Question6")
        {
            miniMap.SetActive(false);
            panel_question6.SetActive(true);
            hieuUng.FadeIn(canvasQUestion6);
        }
        if (collision.gameObject.tag == "Question7")
        {
            miniMap.SetActive(false);
            panel_question7.SetActive(true);
            hieuUng.FadeIn(canvasQUestion7);
        }
        if (collision.gameObject.tag == "Question8")
        {
            miniMap.SetActive(false);
            panel_question8.SetActive(true);
            hieuUng.FadeIn(canvasQUestion8);
        }
        
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
}
