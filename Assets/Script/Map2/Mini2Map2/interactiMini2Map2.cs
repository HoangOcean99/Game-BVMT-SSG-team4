using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class interactiMini2Map2 : MonoBehaviour
{
    public string sceneHome;
    public string sceneCurrent;
    public GameObject panelIntroFirst;
    public Button buttonTiepIntroFirst;
    public GameObject panelChucMung;
    public TextMeshProUGUI textdiem;
    public Button buttonTiepChucMung;
    public GameObject panelThongDiep;
    public Button buttonXacNhanThongDiep;
    public GameObject panelMain;

    private InstancePointMini2Map2 instanceMini2Map2;
    private InstanceVariableMap2 instanceVariableMap2;
    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceVariableMap2 = FindAnyObjectByType<InstanceVariableMap2>();
        Time.timeScale = 0;
        instanceMini2Map2 = FindAnyObjectByType<InstancePointMini2Map2>();
        buttonTiepIntroFirst.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            Time.timeScale = 1;
            panelIntroFirst.SetActive(false);
            panelMain.SetActive(true);
        });
        buttonTiepChucMung.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelChucMung.SetActive(false);
            panelThongDiep.SetActive(true);
        });
        buttonXacNhanThongDiep.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            instanceVariableMap2.objectMini2 = 1;
            instanceGeneral = FindAnyObjectByType<InstanceVariables>();
            instanceGeneral.point += instanceMini2Map2.point;
            instanceMini2Map2.DestroyInstance();
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();

        });
        
    }

    // Update is called once per frame
    void Update()
    {
        if (instanceMini2Map2.point == 24)
        {
            panelMain.SetActive(false);
            Time.timeScale = 0;
            textdiem.text = "<b>Số điểm bạn nhận được là: " + instanceMini2Map2.point + " điểm<b> <sprite=2>";

            panelChucMung.SetActive(true);
        }
    }
}
