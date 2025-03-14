using UnityEngine;

public class ChangeObjectMiniMap2 : MonoBehaviour
{

    public GameObject panelIntroMini1;
    public GameObject panelIntroMini2;

    public GameObject[] listObjectMini1;
    public GameObject[] listObjectMini2;

    private InstanceVariableMap2 instanceVariableMap2;
    private InstanceVariables instanceGeneral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceVariableMap2 = FindAnyObjectByType<InstanceVariableMap2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (instanceVariableMap2.objectMini1 == 1)
        {
            instanceGeneral.move = true;
            foreach (var item in listObjectMini1)
            {
                item.SetActive(false);
            }
            panelIntroMini1.SetActive(false);
        }
        if (instanceVariableMap2.objectMini2 == 1)
        {
            instanceGeneral.move = true;
            foreach (var item in listObjectMini2)
            {
                item.SetActive(false);
            }
            panelIntroMini2.SetActive(false);
        }
    }
}
