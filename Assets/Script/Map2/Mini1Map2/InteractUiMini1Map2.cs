using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractUiMini1Map2 : MonoBehaviour
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

    private instancePointMini1map2 instanceMini1Map2;
    private InstanceVariableMap2 instanceVariableMap2;
    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceVariableMap2 = FindAnyObjectByType<InstanceVariableMap2>();
        Time.timeScale = 0;    
        instanceMini1Map2 = FindAnyObjectByType<instancePointMini1map2>();
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
            instanceVariableMap2.objectMini1 = 1;
            instanceGeneral = FindAnyObjectByType<InstanceVariables>();
            instanceGeneral.point += instanceMini1Map2.point;
            instanceMini1Map2.DestroyInstance();
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
        if(instanceMini1Map2.point == 16)
        {
            Time.timeScale = 0;
            textdiem.text = "<b>Số điểm bạn nhận được là: " + instanceMini1Map2.point + " điểm<b> <sprite=2>";

            panelChucMung.SetActive(true);
        }
    }
}
