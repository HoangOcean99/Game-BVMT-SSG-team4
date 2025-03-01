using UnityEngine;

public class ChallengeAppear : MonoBehaviour
{
    public string currentScene;
    public string NameMini1;
    public GameObject object_temp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Minigame1")
        {   
            object_temp.SetActive(false);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.HideScene(currentScene);
            LoadSceneManager.LoadNewScene(NameMini1);

            
        }

    }
}
