using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public static void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
    public static void UnloadScene(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
    public static void ReturnSceneHome(string sceneName)
    {
        Scene sceneToSwitch = SceneManager.GetSceneByName(sceneName);
        if(sceneToSwitch != null)
        {
            SceneManager.SetActiveScene(sceneToSwitch);
        }
    }
    public static void HideScene(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        if (scene.IsValid())
        {
            foreach (GameObject obj in scene.GetRootGameObjects())
            {
                if (obj.GetComponent<EventSystem>() == null) // Tránh tắt EventSystem
                {
                    obj.SetActive(false);
                }
                else
                {
                    obj.gameObject.SetActive(false); // Tắt Event System
                }
            }
        }
    }

    public static void ShowScene(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        if (scene.IsValid())
        {
            foreach (GameObject obj in scene.GetRootGameObjects())
            {
                obj.SetActive(true);
            }

            // Xóa tất cả Event System dư thừa, chỉ giữ lại một cái duy nhất
            EventSystem[] eventSystems = GameObject.FindObjectsOfType<EventSystem>();
            if (eventSystems.Length > 1)
            {
                for (int i = 1; i < eventSystems.Length; i++) // Giữ cái đầu tiên, xóa các cái sau
                {
                    Destroy(eventSystems[i].gameObject);
                }
            }
        }
    }
    public static void DisableExtraAudioListeners()
    {
        AudioListener[] listeners = GameObject.FindObjectsOfType<AudioListener>();
        if (listeners.Length > 1)
        {
            for (int i = 1; i < listeners.Length; i++) // Giữ lại 1 cái, tắt cái còn lại
            {
                listeners[i].enabled = false;
            }
        }
    }
}
