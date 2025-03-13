using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FindDifference : MonoBehaviour
{
    public Button buttonClick;
    public Button buttonClick2;
    public GameObject circle1;
    public GameObject circle2;
    public TextMeshProUGUI textPoint;

    private InstancePointMini2Map2 instancePoint;
    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        instancePoint = FindAnyObjectByType<InstancePointMini2Map2>();
        buttonClick.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            buttonClick2.interactable = false;
            buttonClick.interactable = false;
            circle1.SetActive(true);
            circle2.SetActive(true);
            instancePoint.point += 2;
        });
    }

    // Update is called once per frame
    void Update()
    {
        textPoint.text = instancePoint.point + "/24";
    }
}
