using Unity.Cinemachine;
using UnityEngine;

public class ScriptSetPlayer : MonoBehaviour
{
    public GameObject boyPlayer;
    public GameObject girlPlayer;
    public Transform boyTr;
    public Transform girlTr;
    public CinemachineCamera virtualCamera;
    public MiniMapCamera minicamera;

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
            if(virtualCamera != null && boyTr != null)
            {
                virtualCamera.Follow = boyTr;
                //virtualCamera.LookAt = boyTr;
            }
            if (minicamera != null)
            {
                minicamera.player = boyPlayer.transform;
            }
        }
        else
        {
            boyPlayer.SetActive(false);
            girlPlayer.SetActive(true);
            Destroy(boyPlayer);
            if (virtualCamera != null && girlTr != null)
            {
                virtualCamera.Follow = girlTr;
                //virtualCamera.LookAt = girlTr;
            }
            if (minicamera != null)
            {
                minicamera.player = girlPlayer.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
