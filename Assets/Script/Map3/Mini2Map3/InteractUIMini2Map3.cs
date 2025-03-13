using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractUIMini2Map3 : MonoBehaviour
{
    public string sceneHome;
    public string sceneCurrent;
    public GameObject panelIntroFirst;
    public Button buttonTiepIntroFirst;
    public GameObject panelChucMung;
    public Button buttonTiepChucMung;
    public GameObject panelThongDiep;
    public Button buttonXacNhanThongDiep;
    public TextMeshProUGUI textChucMung;

    private InstancePointMini2Map3 instanceMini2Map3;
    private InstanceChangeMap3 instanceChangeMap3;

    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceChangeMap3 = FindAnyObjectByType<InstanceChangeMap3>();
        Time.timeScale = 0;
        instanceMini2Map3 = FindAnyObjectByType<InstancePointMini2Map3>();
        buttonTiepIntroFirst.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            Time.timeScale = 1;
            panelIntroFirst.SetActive(false);
        });
        buttonTiepChucMung.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelChucMung.SetActive(false);
            panelThongDiep.SetActive(true);
        });
        buttonXacNhanThongDiep.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            instanceChangeMap3.mini2 = 1;
            Time.timeScale = 1;
            instanceGeneral.point += instanceMini2Map3.point;
            instanceMini2Map3.DestroyInstance();
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
        if(instanceMini2Map3.count == 4)
        {
            textChucMung.text = "<b>Số điểm bạn nhận được là: " + instanceMini2Map3.point + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        }
    }
}
