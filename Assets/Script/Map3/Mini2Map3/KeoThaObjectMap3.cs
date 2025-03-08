using System;
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
    public float toaDoX;
    public float toaDoY;
    public GameObject currentSituation;
    public GameObject newSituation;
    public GameObject currentText;
    public GameObject newText;

    //private TinhDiemMiniGame1 point;
    //private CountObject count;



    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        mainCamera = Camera.main;
        //point = FindAnyObjectByType<TinhDiemMiniGame1>();
        //count = FindAnyObjectByType<CountObject>();
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
                objectVatPham.SetActive(false);
                currentSituation.SetActive(false);
                newSituation.SetActive(true);
                currentText.SetActive(false);
                newText.SetActive(true);
                //point.diem++;
                //count.count++;

            }
            else if (hitCollider != null && (hitCollider.CompareTag(tagThuRacSai1) || hitCollider.CompareTag(tagThuRacSai2) || hitCollider.CompareTag(tagThuRacSai3)))
            {
                objectVatPham.transform.position = new Vector2(toaDoX, toaDoY);
                //objectRac.SetActive(false);
                //point.diem--;
                //count.count++;
            }
        }

    }
}
