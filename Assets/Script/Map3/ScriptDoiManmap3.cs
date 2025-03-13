using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptDoiManmap3 : MonoBehaviour
{
    private InstanceChangeMap3 instancemap3;
    private InstanceQuestionFinish questionFinish;

    public GameObject panelNextMap;
    public Button buttonNextMap;

    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instancemap3 = FindAnyObjectByType<InstanceChangeMap3>();
        questionFinish = FindAnyObjectByType<InstanceQuestionFinish>();
        buttonNextMap.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            questionFinish.countFinish = 0;
            SceneManager.LoadScene("SceneLeaderaBoard");
        });
    }

    // Update is called once per frame  
    void Update()
    {
        if (questionFinish.countFinish == 8 && instancemap3.mini1 == 1 && instancemap3.mini2 == 1)
        {
            panelNextMap.SetActive(true);
        }
    }
}
