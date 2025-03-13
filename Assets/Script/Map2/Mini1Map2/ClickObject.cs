using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    public Button buttonClick;
    public GameObject circle;
    public GameObject tick;

    public TextMeshProUGUI textPoint;
    private instancePointMini1map2 m_Instance;
    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        m_Instance = FindAnyObjectByType<instancePointMini1map2>();
        buttonClick.onClick.AddListener(() =>{
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            buttonClick.interactable = false;
            circle.SetActive(true);
            tick.SetActive(true);
            m_Instance.point+=2;
        });
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = m_Instance.point + "/16";
    }
}
