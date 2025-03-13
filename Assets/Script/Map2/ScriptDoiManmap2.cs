using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptDoiManmap2 : MonoBehaviour
{
    private InstanceVariableMap2 instancemap2;
    private InstanceQuestionFinish questionFinish;

    public GameObject panelNextMap;
    public Button buttonNextMap;

    public AudioSource audioClickButton;
    private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instancemap2 = FindAnyObjectByType<InstanceVariableMap2>();
        questionFinish = FindAnyObjectByType<InstanceQuestionFinish>();
        buttonNextMap.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            questionFinish.countFinish = 0;
            SceneManager.LoadScene("BienScene");
        });
    }

    // Update is called once per frame  
    void Update()
    {
        if (questionFinish.countFinish == 8 && instancemap2.objectMini1 == 1 && instancemap2.objectMini2 == 1)
        {
            panelNextMap.SetActive(true);
        }
    }
}
