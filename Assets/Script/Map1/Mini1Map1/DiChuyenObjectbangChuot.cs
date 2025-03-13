using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiChuyenObjectbangChuot : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 distanceMouseObject;
    private Boolean isDragging = false;
    public String tagThuRacDung;
    public String tagThuRacSai1;
    public String tagThuRacSai2;
    public GameObject objectRac;

    private float ToaDoX;
    private float ToaDoY;

    private TinhDiemMiniGame1 point;
    private CountObject count;

    private CreateNotifiMini1Map1 notification;
    public AudioSource audioClickButton;
    public AudioSource audioCorrectButton;
    public AudioSource audioIncorrectButton;
    private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        ToaDoX = transform.position.x;
        ToaDoY = transform.position.y;
        mainCamera = Camera.main;
        notification = FindAnyObjectByType<CreateNotifiMini1Map1>();
        point = FindAnyObjectByType<TinhDiemMiniGame1>();
        count = FindAnyObjectByType<CountObject>();
    }


    public void OnMouseDown()
    {
        Debug.Log("Bắt đầu kéo đối tượng");
        isDragging = true;
        distanceMouseObject = transform.position - GetMouseWorldPosition();
    }
    public void OnMouseUp()
    {
        isDragging = false;
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = mainCamera.nearClipPlane; // Set độ sâu
        return mainCamera.ScreenToWorldPoint(mouseScreenPosition);
    }
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + distanceMouseObject;
        }

        else
        {
            Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, 0.1f, LayerMask.GetMask("Default")); // Thay đổi kích thước và layer nếu cần
            if (hitCollider != null && hitCollider.CompareTag(tagThuRacDung))
            {
                if (instanceGeneral.sound) audioCorrectButton.PlayOneShot(audioCorrectButton.clip);
                notification.ShowNotification("Chính xác<br>Bạn được +3 điểm", 2);
                objectRac.SetActive(false);
                point.diem+=3;
                count.count++;

            }
            else if(hitCollider != null && (hitCollider.CompareTag(tagThuRacSai1) || hitCollider.CompareTag(tagThuRacSai2)))
            {
                if (instanceGeneral.sound) audioIncorrectButton.PlayOneShot(audioIncorrectButton.clip);
                notification.ShowNotification("Không chính xác<br>Bạn bị -1 điểm", 1);
                objectRac.transform.position = new Vector2(ToaDoX, ToaDoY);
                point.diem--;
            }
        }
        
    }
}
