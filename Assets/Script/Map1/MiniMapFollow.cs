using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    public Transform player; // Nhân vật chính

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = player.position;
            newPosition.z = transform.position.z; // Giữ nguyên giá trị Z để không ảnh hưởng góc nhìn
            transform.position = newPosition;
        }
    }
} 
