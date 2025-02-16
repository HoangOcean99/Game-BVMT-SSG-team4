using UnityEngine;

public class DiChuyenObjectbangChuot : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 distanceMouseObject;
    private bool isDragging = false;

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void OnMouseDown()
    {
        isDragging = true;
        distanceMouseObject = transform.position - GetMouseWorldPosition();
    }
    public void OnMouseUp(){
        isDragging = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
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
