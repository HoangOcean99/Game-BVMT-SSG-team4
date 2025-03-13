using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReturnSceneMini2 : MonoBehaviour
{
    public Button button_returnScene;
    public string sceneHome;
    public string sceneCurrent;
    public GameObject panelIntroFirst;
    public Button buttonXacNhan;
    public Button buttonTiepTuc1;
    public GameObject panelChucMung;
    public TextMeshProUGUI textPoint;
    public Button buttonTiepTuc2;
    public GameObject panel_thongDiep;
    public AudioSource audioClickButton;

    private DiemSoMinigame2 diemMini2Map1;
    private InstaceObjectMinigame2 miniGame2;
    private InstanceVariables instanceGeneral;
    void Start()
    {
        Time.timeScale = 0;
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        diemMini2Map1 = FindAnyObjectByType<DiemSoMinigame2>();
        miniGame2 = FindAnyObjectByType<InstaceObjectMinigame2>();
        buttonXacNhan.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            Time.timeScale = 1;
            panelIntroFirst.SetActive(false);   
        });
        buttonTiepTuc1.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            buttonTiepTuc1.enabled = false;
            textPoint.text = "<b>Số điểm bạn nhận được là: " + diemMini2Map1.point + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        });
        buttonTiepTuc2.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            instanceGeneral.point += diemMini2Map1.point;
            panelChucMung.SetActive(false);
            panel_thongDiep.SetActive(true);
        });
        button_returnScene.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            LoadSceneManager.DisableExtraAudioListeners();
            LoadSceneManager.disableEventSystem();
            LoadSceneManager.UnloadScene(sceneCurrent);
            LoadSceneManager.HideScene(sceneCurrent);
            LoadSceneManager.ShowScene(sceneHome);
            Time.timeScale = 1;
            checkMainPlayer();
            miniGame2.change = 1;
        });
    }

    // Update is called once per frame  
    void Update()
    {
        
    }
    public void checkMainPlayer()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length > 1)
        {
            // Nếu có hơn 1 mainPlayer, xóa bớt 1 cái
            for (int i = 1; i < players.Length; i++)
            {
                Destroy(players[i]);
            }
        }
    }
}
