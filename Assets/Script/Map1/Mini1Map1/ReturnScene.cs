using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnScene : MonoBehaviour
{
    public Button button_returnScene;
    public string sceneHome;
    public string sceneCurrent;

    public Button buttonTiep1;
    public GameObject panelChucMung;
    public Button buttonTiepCon;
    public GameObject panelThongDiep;

    public TextMeshProUGUI textThongBaoDiem;

    private TinhDiemMiniGame1 pointMiniGame1;

    private InstaceObjectMinigam1 miniGame1;
    private InstanceVariables instanceGeneral;
    private TinhDiemMiniGame1 tinhDiemMini1;
    // Start is called once before the first exe
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tinhDiemMini1 = FindAnyObjectByType<TinhDiemMiniGame1>();  
        
        miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
        buttonTiep1.onClick.AddListener(() =>
        {
            pointMiniGame1 = FindAnyObjectByType<TinhDiemMiniGame1>();
            textThongBaoDiem.text = "<b>Số điểm bạn nhận được là: " + pointMiniGame1.diem + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        });
        button_returnScene.onClick.AddListener(() =>
        {
            instanceGeneral = FindAnyObjectByType<InstanceVariables>();
            instanceGeneral.point += tinhDiemMini1.diem;
            tinhDiemMini1.DestroyInstance();
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            miniGame1.change = 1;

        });
        buttonTiepCon.onClick.AddListener(() =>
        {
            panelChucMung.SetActive(false);
            panelThongDiep.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {   
        


    }
}
