using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScriptInteractUIMini1Map3 : MonoBehaviour
{
    public string sceneHome;
    public string sceneCurrent;
    public GameObject panelIntroFirst;
    public Button buttonTiepIntroFirst;
    public GameObject panelChucMung;
    public Button buttonTiepChucMung;
    public GameObject panelThongDiep;
    public Button buttonXacNhanThongDiep;

    private InstancePointMini1Map3 instanceMini1Map3;
    private InstanceChangeMap3 instanceChangeMap3;
    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceChangeMap3 = FindAnyObjectByType<InstanceChangeMap3>();
        Time.timeScale = 0;
        instanceMini1Map3 = FindAnyObjectByType<InstancePointMini1Map3>();
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
            instanceChangeMap3.mini1 = 1;
            Time.timeScale = 1;
            instanceGeneral.point += instanceMini1Map3.point;
            instanceMini1Map3.DestroyInstance();
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
    }
}
