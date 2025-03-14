using System.Collections.Generic;
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
    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    public AudioSource audioCorrectButton;
    public AudioSource audioIncorrectButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instancePoint = FindAnyObjectByType<InstancePointMini1Map3>();
        startPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (option == 1)
        {
            if (instanceGeneral.sound) audioCorrectButton.PlayOneShot(audioCorrectButton.clip);
            instancePoint.point += 2;
            objectVatThe.SetActive(false);
            Destroy(objectVatThe);
        }
        else
        {
            if (instanceGeneral.sound) audioIncorrectButton.PlayOneShot(audioIncorrectButton.clip);
            List<GameObject> newList = TaoObjectNgauNhienMap3.instantiatedObjects;
            Time.timeScale = 0;
            //object_panelThongDiepMini2.SetActive(true);
            foreach (var obj in newList)
            {
                if (obj != null)
                {
                    Destroy(obj);
                }
            }
            newList.Clear();
            objectVatThe.SetActive(false);
            textThongDiep1.text = "Thử thách đã kết thúc do bạn đã vớt phải loài cá sống. Nhưng chắc hẳn bạn đã lấy được nhiều điểm";
            textThongDiep2.text = "<b>Số điểm bạn nhận được là: " + instancePoint.point + " điểm<b> <sprite=2>";
            panelChucMung.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (instancePoint.point == 10)
        {
            speedNPC = 6f;
        }
        if (instancePoint.point == 17)
        {
            speedNPC = 10f;
        }
        if (instancePoint.point == 25)
        {
            speedNPC = 15f;
        }
        if (instancePoint.point == 35)
        {
            speedNPC = 20f;
        }
        if (instancePoint.point == 45)
        {
            speedNPC = 25f;
        }
        if (instancePoint.point == 50)
        {
            speedNPC = 30f;
        }
        if (instancePoint.point == 60)
        {
            speedNPC = 35f;
        }
        if (instancePoint.point == 70)
        {
            speedNPC = 40f;
        }
        Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, 0.1f, LayerMask.GetMask("Default")); // Thay đổi kích thước và layer nếu cần
        if (hitCollider != null && hitCollider.CompareTag("TinhDiem"))
        {
            if (option == 1)
            {
                if (instanceGeneral.sound) audioIncorrectButton.PlayOneShot(audioIncorrectButton.clip);
                List<GameObject> newList = TaoObjectNgauNhienMap3.instantiatedObjects;
                //object_panelThongDiepMini2.SetActive(true);
                foreach (var obj in newList)
                {
                    if (obj != null)
                    {
                        Destroy(obj);
                    }
                }
                newList.Clear();
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
