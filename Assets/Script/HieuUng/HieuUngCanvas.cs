using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HieuUngCanvas : MonoBehaviour
{
    public float fadeDuration = 1f;

    public void FadeIn(CanvasGroup canvasGroup)
    {
        StartCoroutine(FadeCanvas(0, 1, canvasGroup));
    }

    public void FadeOut(CanvasGroup canvasGroup)
    {
        StartCoroutine(FadeCanvas(1, 0, canvasGroup));
    }

    IEnumerator FadeCanvas(float start, float end, CanvasGroup canvasGroup)
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
