using System.Collections;
using TMPro;
using UnityEngine;
using static UnityEditor.MaterialProperty;

public class CountDownTime : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeRemaining = 30f;
    public GameObject panelchucMung;
    public TextMeshProUGUI textPoint;

    private InstancePointMini2Map2 instanceMini2Map2;
    void Start()
    {
        instanceMini2Map2 = FindAnyObjectByType<InstancePointMini2Map2>();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            timerText.text = "0:"+timeRemaining;
            yield return new WaitForSeconds(1f);
            timeRemaining--;
        }
        timerText.text = "Time's up!";
        Time.timeScale = 0;
        textPoint.text = "<b>Số điểm bạn nhận được là: " + instanceMini2Map2.point + " điểm<b> <sprite=2>";
        panelchucMung.SetActive(true);
    }
}
