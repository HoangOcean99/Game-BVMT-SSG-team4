using UnityEngine;

public class ScriptChangeObject : MonoBehaviour
{
    public GameObject[] objectRac1;
    public GameObject panelMiniGame1;

    public GameObject[] objectRac2;
    public GameObject panelMiniGame2;

    private InstaceObjectMinigam1 miniGame1;
    private InstaceObjectMinigame2 miniGame2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
        miniGame2 = FindAnyObjectByType<InstaceObjectMinigame2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(miniGame1.change == 1)
        {
            foreach (var item in objectRac1)
            {
                item.SetActive(false);
            }
            panelMiniGame1.SetActive(false);
        }
        if(miniGame2.change == 1)
        {
            foreach (var item in objectRac2)
            {
                item.SetActive(false);
            }
            panelMiniGame2.SetActive(false);
        }
    }
}
