using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownTime : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeRemaining = 10f;

    void Start()
    {
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
    }
}
