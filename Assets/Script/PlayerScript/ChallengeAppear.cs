using UnityEngine;

public class ChallengeAppear : MonoBehaviour
{

    public GameObject panel_miniGame1;
    public GameObject panel_miniGame2;
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
    }
}
