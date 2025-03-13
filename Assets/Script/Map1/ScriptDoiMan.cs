using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptDoiMan : MonoBehaviour
{
    private InstaceObjectMinigam1 miniGame1;
    private InstaceObjectMinigame2 miniGame2;
    private InstanceVariables instanceGeneral;
    private InstanceQuestionFinish questionFinish;

    public AudioSource audioClickButton;
    public GameObject panelNextMap;
    public Button buttonNextMap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioClickButton.time = 0f;
        audioClickButton.pitch = 1.2f;
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
        miniGame2 = FindAnyObjectByType<InstaceObjectMinigame2>();
        questionFinish = FindAnyObjectByType<InstanceQuestionFinish>();
        buttonNextMap.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            questionFinish.countFinish = 0;
            SceneManager.LoadScene("RungScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (questionFinish.countFinish == 8 && miniGame2.change == 1 && miniGame1.change == 1)
        {
            panelNextMap.SetActive(true);
        }
    }
}
