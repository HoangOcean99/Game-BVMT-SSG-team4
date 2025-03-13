using TMPro;
using UnityEngine;

public class UpdatePoint : MonoBehaviour
{
    public TextMeshProUGUI textPointMap1;
    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        textPointMap1.text = instanceGeneral.point+""; 
    }
}
