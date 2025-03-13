using UnityEngine;
using UnityEngine.UI;

public class ChangeOpacity : MonoBehaviour
{
    public CanvasGroup button1;
    public CanvasGroup button2;

    private float activeOpacity = 1f;  // Độ sáng khi bật
    private float inactiveOpacity = 0.5f; // Độ mờ khi tắt

    public void ActivateButton1()
    {
        SetButtonOpacity(button1, activeOpacity);
        SetButtonOpacity(button2, inactiveOpacity);
    }

    public void ActivateButton2()
    {
        SetButtonOpacity(button1, inactiveOpacity);
        SetButtonOpacity(button2, activeOpacity);
    }

    private void SetButtonOpacity(CanvasGroup button, float opacity)
    {
        button.alpha = opacity;
        button.interactable = true; // Giữ nút luôn có thể bấm
        button.blocksRaycasts = true;
    }
}
