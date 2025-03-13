using TMPro;
using UnityEngine;

public class SetTextPoint : MonoBehaviour
{
    public TextMeshProUGUI textPoint;
    private InstancePointMini1Map3 instancePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instancePoint = FindAnyObjectByType<InstancePointMini1Map3>();
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = instancePoint.point + "";
    }
}
