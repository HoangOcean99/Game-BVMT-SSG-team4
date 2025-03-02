using UnityEngine;

public class GameOverMiniGame2 : MonoBehaviour
{
    public GameObject object_panelThongDiepMini2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Opposite")
        {
            Time.timeScale = 0;
            object_panelThongDiepMini2.SetActive(true);
        }
    }
}
