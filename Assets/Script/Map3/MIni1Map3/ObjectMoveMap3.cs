using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    private Vector2 startPosition;
    public float speedNPC = 3f;
    public int option;
    public GameObject objectVatThe;
    public GameObject panelChucMung;
    public TextMeshProUGUI textThongDiep1;
    public TextMeshProUGUI textThongDiep2;

    private InstancePointMini1Map3 instancePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instancePoint = FindAnyObjectByType<InstancePointMini1Map3>();
        startPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (option == 1)
        {
            instancePoint.point += 2;
            objectVatThe.SetActive(false);
            Destroy(objectVatThe);
        }
        else
        {
            objectVatThe.SetActive(false);
            Time.timeScale = 0f;
            textThongDiep1.text = "Thử thách đã kết thúc do bạn đã vớt phải loài cá sống. Nhưng chắc hẳn bạn đã lấy được nhiều điểm";
            textThongDiep2.text = "<b>Số điểm bạn nhận được là: " + instancePoint.point + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, 0.1f, LayerMask.GetMask("Default")); // Thay đổi kích thước và layer nếu cần
        if (hitCollider != null && hitCollider.CompareTag("TinhDiem"))
        {
            if (option == 1)
            {
                objectVatThe.SetActive(false);
                //instancePoint.point += 2;
                Time.timeScale = 0f;
                textThongDiep1.text = "Thử thách đã kết thúc do bạn đã để lọt rác. Nhưng chắc hẳn bạn đã lấy được nhiều điểm";
                textThongDiep2.text = "<b>Số điểm bạn nhận được là: " + instancePoint.point + " điểm<b> <sprite=2>";
                panelChucMung.SetActive(true);
            }
            else
            {
                objectVatThe.SetActive(false);
                Destroy(objectVatThe);
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, startPosition + new Vector2(-60f, 0f), speedNPC * Time.deltaTime);
    }
}
