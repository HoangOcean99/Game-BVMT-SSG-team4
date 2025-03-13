using System.Collections.Generic;
using UnityEngine;

public class TaoNgauNhienObject : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 5f;

    private int speedSpawn = 1;
    private DiemSoMinigame2 diemSoMinigame2;
    public static List<GameObject> instantiatedObjects = new List<GameObject>();
    private Move player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Move>();
        InvokeRepeating("SpawmObject", 1f, spawmTime);
        diemSoMinigame2 = FindAnyObjectByType<DiemSoMinigame2>();
    }

    void SpawmObject()
    {
        float[] positions = { 5.7f, 0.9f, -4.4f, -9.6f };
        for (int i = 0; i < speedSpawn; i++)
        {
            int randomIndex = Random.Range(0, objectsToSpawm.Length);
            GameObject randomObject = objectsToSpawm[randomIndex];

            Vector2 positionRandom = new Vector2(22.8f, positions[Random.Range(0, positions.Length)]);

            GameObject newObj = Instantiate(randomObject, positionRandom, Quaternion.identity);
            instantiatedObjects.Add(newObj);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (diemSoMinigame2.point == 20)
        {
            speedSpawn=2;
        }
        if (diemSoMinigame2.point  == 32)
        {
            speedSpawn=3;
        }
        if (diemSoMinigame2.point == 110)
        {
            speedSpawn = 4;
        }
    }
}
