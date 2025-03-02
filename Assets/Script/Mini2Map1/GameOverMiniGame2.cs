using UnityEngine;

public class GameOverMiniGame2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Opposite")
        {
            Time.timeScale = 0;
        }
    }
}
