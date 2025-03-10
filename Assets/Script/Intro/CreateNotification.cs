using TMPro;
using UnityEngine;

public class CreateNotification : MonoBehaviour
{
    public GameObject notificationPanel;
    private float displayTime = 20.7f; // Thời gian hiển thị

    public void ShowNotification()
    {
        notificationPanel.gameObject.SetActive(true);
        Invoke(nameof(HideNotification), displayTime);
    }

    private void HideNotification()
    {
        notificationPanel.gameObject.SetActive(false);
    }
}
