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

    private TinhDiemMiniGame1 point;
    private CountObject count;



    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        mainCamera = Camera.main;
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
                objectRac.SetActive(false);
                point.diem++;
                count.count++;

            }
            else if(hitCollider != null && (hitCollider.CompareTag(tagThuRacSai1) || hitCollider.CompareTag(tagThuRacSai2)))    
            {
                objectRac.SetActive(false);
                point.diem--;
                count.count++;
            }
        }
        
    }
}
