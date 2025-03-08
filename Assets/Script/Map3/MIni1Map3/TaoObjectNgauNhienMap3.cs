using System.Collections.Generic;
using UnityEngine;

public class TaoObjectNgauNhien : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 5f;

    private int speedSpawn = 2;
    public static List<GameObject> instantiatedObjects = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawmObject", 1f, spawmTime);
    }

    void SpawmObject()
    {
        float[] positions = { 3.324093f, 0.16f, -3.538653f, -7.42f };
        for (int i = 0; i < speedSpawn; i++)
        {
            int randomIndex = Random.Range(0, objectsToSpawm.Length);
            GameObject randomObject = objectsToSpawm[randomIndex];

            Vector2 positionRandom = new Vector2(17.72f, positions[Random.Range(0, positions.Length)]);

            GameObject newObj = Instantiate(randomObject, positionRandom, Quaternion.identity);
            instantiatedObjects.Add(newObj);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
