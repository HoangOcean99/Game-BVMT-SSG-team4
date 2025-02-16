using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{ 
    private Camera mainCamera;
    private Vector3 distanceMouseObject;
    private Boolean isDragging = false;
    public String tagThuRac;
    public GameObject objectRac;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hu");
        if (collision.gameObject.tag == "TRVoCo")
        {
            Debug.Log("Hellow");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    void Start()
    {
        mainCamera = Camera.main;
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

    }
}