using TMPro;
using UnityEngine;

public class CreateNotifiMini1Map1 : MonoBehaviour
{
    public GameObject notificationPanel;
    public GameObject notificationPanelDung;
    public TextMeshProUGUI textNo;
    public TextMeshProUGUI textNoDung;
    private float displayTime = 0.65f; // Thời gian hiển thị

    public void ShowNotification(string message, int option)
    {
        if(option == 1)
        {
            textNo.text = message;
            notificationPanel.gameObject.SetActive(true);
            Invoke(nameof(HideNotification), displayTime);
        }
        else
        {
            textNoDung.text = message;
            notificationPanelDung.gameObject.SetActive(true);
            Invoke(nameof(HideNotification), displayTime);
        }


    }

    private void HideNotification()
    {
        notificationPanel.gameObject.SetActive(false);
        notificationPanelDung.gameObject.SetActive(false);
    }
}
