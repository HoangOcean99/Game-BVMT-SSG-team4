using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{ 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hu");
        if (collision.gameObject.tag == "RavVoCo")
        {
            Debug.Log("Hellow");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}