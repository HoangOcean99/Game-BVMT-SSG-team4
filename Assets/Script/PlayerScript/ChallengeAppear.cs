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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Minigame1")
        {
            panel_miniGame1.SetActive(true);
        }
        if (collision.gameObject.tag == "Minigame2")
        {
            panel_miniGame2.SetActive(true);
        }
        if (collision.gameObject.tag == "Question1")
        {
            panel_question1.SetActive(true);
        }
        if (collision.gameObject.tag == "Question2")
        {
            panel_question2.SetActive(true);
        }
        if (collision.gameObject.tag == "Question3")
        {
            panel_question3.SetActive(true);
        }
        if (collision.gameObject.tag == "Question4")
        {
            panel_question4.SetActive(true);
        }
        if (collision.gameObject.tag == "Question5")
        {
            panel_question5.SetActive(true);
        }
        if (collision.gameObject.tag == "Question6")
        {
            panel_question6.SetActive(true);
        }
        if (collision.gameObject.tag == "Question7")
        {
            panel_question7.SetActive(true);
        }
        if (collision.gameObject.tag == "Question8")
        {
            panel_question8.SetActive(true);
        }
    }
}
