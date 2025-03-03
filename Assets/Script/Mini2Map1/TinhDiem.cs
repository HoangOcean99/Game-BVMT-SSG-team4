using TMPro;
using UnityEngine;

public class TinhDiem : MonoBehaviour
{
    public TextMeshProUGUI textDiemSo;
    public GameObject objectNpc;

    private DiemSoMinigame2 diemSo;
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TinhDiem")
        {
            diemSo++;
        }
    }*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diemSo = FindAnyObjectByType<DiemSoMinigame2>();
        textDiemSo.text = diemSo.point + "";
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, 0.1f, LayerMask.GetMask("Default")); // Thay đổi kích thước và layer nếu cần
        if (hitCollider != null && hitCollider.CompareTag("TinhDiem"))
        {
            diemSo.point += 1;
            objectNpc.SetActive(false);
        }
        textDiemSo.text = diemSo.point + "";
    }
}
