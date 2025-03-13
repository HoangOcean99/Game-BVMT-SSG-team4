using TMPro;
using UnityEngine;

public class SetTextPointMini2Map3 : MonoBehaviour
{
    public TextMeshProUGUI textPoint;

    private InstancePointMini2Map3 instanceMini2Map3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        instanceMini2Map3 = FindAnyObjectByType<InstancePointMini2Map3>();
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = instanceMini2Map3.point + "";
    }
}
