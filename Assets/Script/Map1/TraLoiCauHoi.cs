using UnityEngine;
using UnityEngine.UI;

public class TraLoiCauHoi : MonoBehaviour
{
    public GameObject mainQuestion;
    public GameObject[] objectDisappear;
    public Button buttonCorrect;
    public Button buttonIncorrect1;
    public Button buttonIncorrect2;
    public Button buttonIncorrect3;
    public Button buttonExit;

    public GameObject panel_question;
    public GameObject panel_Congra;

    public GameObject miniMap;

    private CreateNotification hienThongBao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hienThongBao = FindAnyObjectByType<CreateNotification>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonExit.onClick.AddListener(() =>
        {
            miniMap.SetActive(true);
            mainQuestion.SetActive(false);
            foreach (GameObject obj in objectDisappear)
            {
                //obj.SetActive(false);
                Destroy(obj);
            }
        });
        buttonCorrect.onClick.AddListener(() =>
        {
            panel_question.SetActive(false);
            panel_Congra.SetActive(true);
        });
        buttonIncorrect1.onClick.AddListener(() =>
        {
            hienThongBao.ShowNotification();
        });
        buttonIncorrect2.onClick.AddListener(() =>
        {
            hienThongBao.ShowNotification();
        });
        buttonIncorrect3.onClick.AddListener(() =>
        {
            hienThongBao.ShowNotification();
        });
    }
}
