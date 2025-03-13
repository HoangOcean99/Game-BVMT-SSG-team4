using UnityEngine;
using UnityEngine.UI;

public class HorizontalLimit : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float minX = -500f; // Giới hạn kéo sang trái
    public float maxX = 0f;    // Giới hạn kéo sang phải

    void LateUpdate()
    {
        Vector2 pos = scrollRect.content.anchoredPosition;

        // Chỉ giới hạn khi người dùng kéo vượt quá giới hạn
        if (pos.x < minX) pos.x = minX;
        if (pos.x > maxX) pos.x = maxX;

        scrollRect.content.anchoredPosition = pos;
    }
}