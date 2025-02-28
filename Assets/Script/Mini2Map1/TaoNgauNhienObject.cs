using UnityEngine;

public class TaoNgauNhienObject : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawmObject", 1f, spawmTime);
    }

    void SpawmObject()
    {
        float[] positions = { 5.7f, 0.9f, -4.4f, -9.6f };
        int randomIndex = Random.Range(0, objectsToSpawm.Length);
        GameObject randomObject = objectsToSpawm[randomIndex];

        Vector2 positionRandom = new Vector2(22.8f, positions[Random.Range(0, positions.Length)]);

        Instantiate(randomObject, positionRandom, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
