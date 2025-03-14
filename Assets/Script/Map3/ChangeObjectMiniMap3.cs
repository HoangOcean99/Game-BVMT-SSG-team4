using UnityEngine;

public class ChangeObjectMiniMap3 : MonoBehaviour
{
    private InstanceChangeMap3 instanceChange;
    public GameObject[] objectMini1;
    public GameObject[] objectMini2;
    public GameObject panelMini1;
    public GameObject panelMini2;
    private InstanceVariables instanceGeneral;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instanceChange = FindAnyObjectByType<InstanceChangeMap3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(instanceChange.mini1 == 1)
        {
            Time.timeScale = 1;
            instanceGeneral.move = true;
            foreach (var item in objectMini1)
            {
                item.SetActive(false);
            }
            panelMini1.SetActive(false);
        }
        if (instanceChange.mini2 == 1)
        {
            Time.timeScale = 1;
            instanceGeneral.move = true;
            foreach (var item in objectMini2)
            {
                item.SetActive(false);
            }
            panelMini2.SetActive(false);
        }
    }
}
