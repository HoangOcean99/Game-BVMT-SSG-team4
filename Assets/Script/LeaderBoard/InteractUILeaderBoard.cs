using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InteractUILeaderBoard : MonoBehaviour
{
    public Button buttonTiep;
    public GameObject panelButtonTiep;
    public GameObject panelLeaderBoard;
    public GameObject panelEndGame;

    private InstanceVariables instanceGeneral;
    public AudioSource audioClickButton;
    private float time = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        StartCoroutine(HienButton());
        buttonTiep.onClick.AddListener(() =>
        {
            if (instanceGeneral.sound) audioClickButton.PlayOneShot(audioClickButton.clip);
            panelLeaderBoard.SetActive(false);
            panelEndGame.SetActive(true);
        });
    }

    private IEnumerator HienButton()
    {
        while(time > 0){
            time -= Time.deltaTime;
            yield return null;
        }
        panelButtonTiep.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
