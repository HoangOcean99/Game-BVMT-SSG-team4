using Unity.Cinemachine;
using UnityEngine;

public class ScriptSetPlayerMin2Map1 : MonoBehaviour
{
    public GameObject boyPlayer;
    public GameObject girlPlayer;
    

    private InstanceVariables instanceGeneral;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        if (instanceGeneral.OptionPlayer)
        {
            boyPlayer.SetActive(true);
            girlPlayer.SetActive(false);
            Destroy(girlPlayer);
            
        }
        else
        {
            boyPlayer.SetActive(false);
            girlPlayer.SetActive(true);
            Destroy(boyPlayer);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
