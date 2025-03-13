using TMPro;
using UnityEngine;

public class SetTextPointMap3 : MonoBehaviour
{
    public TextMeshProUGUI textPoint;
    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = instanceGeneral.point + "";
    }
}
