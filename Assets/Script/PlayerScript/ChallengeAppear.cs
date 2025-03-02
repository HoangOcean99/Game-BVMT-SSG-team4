using UnityEngine;

public class ChallengeAppear : MonoBehaviour
{

    public GameObject panel_miniGame1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Minigame1")
        {
            panel_miniGame1.SetActive(true);
        }

    }
}
