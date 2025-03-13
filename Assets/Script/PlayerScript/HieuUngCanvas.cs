using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HieuUngCanvas : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1f;

    public void FadeIn()
    {
        StartCoroutine(FadeCanvas(0, 1));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvas(1, 0));
    }

    IEnumerator FadeCanvas(float start, float end)
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, elapsedTime / fadeDuration);
            yield return null;
        }
        canvasGroup.alpha = end;
    }
}
