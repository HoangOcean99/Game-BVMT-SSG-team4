using UnityEngine;

public class TaoNgauNhienObject : MonoBehaviour
{
    public GameObject[] objectsToSpawm;
    public float spawmTime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawmObject", 0f, spawmTime);
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, objectsToSpawm.Length);
        GameObject randomObject = objectsToSpawm[randomIndex];

        Vector2 positionRandom = new Vector2(Random.Range(-15, 15), Random.Range(-7, 7));

        Instantiate(randomObject, positionRandom, Quaternion.identity);
    }
}
