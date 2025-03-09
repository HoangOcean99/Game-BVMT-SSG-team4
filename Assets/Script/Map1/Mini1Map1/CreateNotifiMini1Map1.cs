using TMPro;
using UnityEngine;

public class CreateNotifiMini1Map1 : MonoBehaviour
{
    public GameObject notificationPanel;
    public TextMeshProUGUI textNo;
    private float displayTime = 0.65f; // Thời gian hiển thị

    public void ShowNotification(string message)
    {
        textNo.text = message;
        notificationPanel.gameObject.SetActive(true);
        Invoke(nameof(HideNotification), displayTime);
    }

    private void HideNotification()
    {
        notificationPanel.gameObject.SetActive(false);
    }
}
