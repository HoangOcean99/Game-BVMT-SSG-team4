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

    public TextMeshProUGUI textThongBaoDiem;

    private TinhDiemMiniGame1 pointMiniGame1;

    private InstaceObjectMinigam1 miniGame1;
    // Start is called once before the first exe
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
        buttonTiep1.onClick.AddListener(() =>
        {
            pointMiniGame1 = FindAnyObjectByType<TinhDiemMiniGame1>();
            textThongBaoDiem.text = "<b>Số điểm bạn nhận được là: " + pointMiniGame1.diem + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        });
        button_returnScene.onClick.AddListener(() =>
        {
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            miniGame1.change = 1;

        });
    }

    // Update is called once per frame
    void Update()
    {   
        


    }
}
