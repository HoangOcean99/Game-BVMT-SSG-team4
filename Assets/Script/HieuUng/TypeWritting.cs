
using UnityEngine;
using TMPro;
using System.Collections;

public class TypeWritting : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.05f;

    private string fullText;

    void Start()
    {
        fullText = textMeshPro.text;
        textMeshPro.text = "";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            textMeshPro.text += fullText[i];
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}