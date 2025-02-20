using UnityEngine;

public class DiChuyenObjectScipt : MonoBehaviour
{
    private Vector2 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, startPosition + new Vector2(-30f, 0f), 30f * Time.deltaTime);
    }
}
