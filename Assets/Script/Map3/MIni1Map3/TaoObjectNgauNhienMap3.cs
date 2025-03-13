using System.Collections.Generic;
using UnityEngine;

public class TaoObjectNgauNhienMap3 : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 5f;

    private int speedSpawn = 2;
    public static List<GameObject> instantiatedObjects = new List<GameObject>();
    private InstancePointMini1Map3 instancePointMap3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instancePointMap3 = FindAnyObjectByType<InstancePointMini1Map3>();
        InvokeRepeating("SpawmObject", 1f, spawmTime);
    }

    void SpawmObject()
    {
        float[] positions = { 3.324093f, 0.16f, -3.538653f, -7.42f };
        List<float> availablePositions = new List<float>(positions); // Tạo danh sách tạm

        for (int i = 0; i < speedSpawn && availablePositions.Count > 0; i++)
        {
            int randomIndex = Random.Range(0, objectsToSpawm.Length);
            GameObject randomObject = objectsToSpawm[randomIndex];

            // Chọn vị trí y ngẫu nhiên từ danh sách tạm
            int positionIndex = Random.Range(0, availablePositions.Count);
            float posY = availablePositions[positionIndex];

            // Xóa vị trí đã chọn để tránh trùng lặp
            availablePositions.RemoveAt(positionIndex);

            Vector2 positionRandom = new Vector2(17.72f, posY);
            GameObject newObj = Instantiate(randomObject, positionRandom, Quaternion.identity);
            instantiatedObjects.Add(newObj);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (instancePointMap3.point == 30)
        {
            speedSpawn = 2;
        }
        if (instancePointMap3.point == 50)
        {
            speedSpawn = 3;
        }
        if (instancePointMap3.point == 65)
        {
            speedSpawn = 4;
        }
    }
}
