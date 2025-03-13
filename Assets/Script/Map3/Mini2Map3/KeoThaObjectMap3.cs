using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeoThaObjectMap3 : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 distanceMouseObject;
    private Boolean isDragging = false;
    public String tagThuRacDung;
    public String tagThuRacSai1;
    public String tagThuRacSai2;
    public String tagThuRacSai3;
    public GameObject objectVatPham;

    public GameObject currentSituation;
    public GameObject newSituation;
    public GameObject currentText;
    public GameObject newText;
    public GameObject objectTitle;

    private InstancePointMini2Map3 pointMini2Map3;
    private CreateNotifiMini1Map1 createNotification;
    private float toaDoX;
    private float toaDoY;

    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    public AudioSource audioCorrectButton;
    public AudioSource audioIncorrectButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        toaDoX = transform.position.x;
        toaDoY = transform.position.y;
        mainCamera = Camera.main;
        pointMini2Map3 = FindAnyObjectByType<InstancePointMini2Map3>();
        createNotification = FindAnyObjectByType<CreateNotifiMini1Map1>();
    }


    public void OnMouseDown()
    {
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
                createNotification.ShowNotification("Chính xác<br>Bạn được +3 điểm", 2);
                objectVatPham.SetActive(false);
                currentSituation.SetActive(false);
                newSituation.SetActive(true);
                currentText.SetActive(false);
                newText.SetActive(true);
                objectTitle.SetActive(false);
                pointMini2Map3.point += 3;
                pointMini2Map3.count++;

            }
            else if (hitCollider != null && (hitCollider.CompareTag(tagThuRacSai1) || hitCollider.CompareTag(tagThuRacSai2) || hitCollider.CompareTag(tagThuRacSai3)))
            {
                if (instanceGeneral.sound) audioIncorrectButton.PlayOneShot(audioIncorrectButton.clip);
                createNotification.ShowNotification("Không chính xác<br>Bạn bị -1 điểm", 1);
                objectVatPham.transform.position = new Vector2(toaDoX, toaDoY);
                pointMini2Map3.point--;
            }
        }

    }
}
