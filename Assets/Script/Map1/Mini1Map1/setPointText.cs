using TMPro;
using UnityEngine;

public class setPointText : MonoBehaviour
{
    private TinhDiemMiniGame1 point;
    private CountObject count;

    public TextMeshProUGUI textPoint;
    public GameObject buttonReturnHome;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        point = FindAnyObjectByType<TinhDiemMiniGame1>();
        count = FindAnyObjectByType<CountObject>();

    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = point.diem+ "";
        if(count.count == 20)
        {
            buttonReturnHome.SetActive(true);
        }
    }
}
