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

    //private InstancePointMini2Map2 instanceMini2Map2;
    //private InstanceVariableMap2 instanceVariableMap2;
    //private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        //instanceVariableMap2 = FindAnyObjectByType<InstanceVariableMap2>();
        Time.timeScale = 0;
        //instanceMini2Map2 = FindAnyObjectByType<InstancePointMini2Map2>();
        buttonTiepIntroFirst.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            panelIntroFirst.SetActive(false);
        });
        buttonTiepChucMung.onClick.AddListener(() =>
        {
            panelChucMung.SetActive(false);
            panelThongDiep.SetActive(true);
        });
        buttonXacNhanThongDiep.onClick.AddListener(() =>
        {
            //instanceVariableMap2.objectMini2 = 1;
            //instanceGeneral = FindAnyObjectByType<InstanceVariables>();
            //instanceGeneral.point += instanceMini2Map2.point;
            //instanceMini2Map2.DestroyInstance();
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
