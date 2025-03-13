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
    public TextMeshProUGUI textChucMung;

    private InstancePointMini2Map2 instancePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instancePoint = FindAnyObjectByType<InstancePointMini2Map2>();
        buttonClick.onClick.AddListener(() =>
        {
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
