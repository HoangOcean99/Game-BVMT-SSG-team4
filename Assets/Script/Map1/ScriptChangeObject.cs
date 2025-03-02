using UnityEngine;

public class ScriptChangeObject : MonoBehaviour
{
    public GameObject[] objectRac1;
    public GameObject panelMiniGame1;

    private InstaceObjectMinigam1 miniGame1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miniGame1 = FindAnyObjectByType<InstaceObjectMinigam1>();
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
    }
}
