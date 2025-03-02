using UnityEngine;

public class TaoNgauNhienObject : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 5f;

    private int speedSpawn = 1;
    private DiemSoMinigame2 diemSoMinigame2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

            Instantiate(randomObject, positionRandom, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (diemSoMinigame2.point == 10)
        {
            speedSpawn=3;
        }
        if (diemSoMinigame2.point == 16)
        {
            speedSpawn=4;
        }
    }
}
