using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptPause : MonoBehaviour
{
    public GameObject panelPause;
    public Button buttonTiep;
    public Button buttonThoat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonTiep.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
        });
        buttonThoat.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("IntroScene");
            Time.timeScale = 1;
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
        }
    }
}
