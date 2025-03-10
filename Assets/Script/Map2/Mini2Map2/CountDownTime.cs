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

    //private instancePointMini1map2 instanceMini1Map2;
    void Start()
    {
        //instanceMini1Map2 = FindAnyObjectByType<instancePointMini1map2>();
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
        //textPoint.text = "<b>Số điểm bạn nhận được là: " + instanceMini1Map2.point + " điểm<b> <sprite=2>";
        panelchucMung.SetActive(true);
    }
}
