using UnityEngine;

public class DiChuyenObjectScipt : MonoBehaviour
{
    private Vector2 startPosition;
    public float speedNPC= 3f;

    private DiemSoMinigame2 diemSoMinigame2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diemSoMinigame2 = FindAnyObjectByType<DiemSoMinigame2>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(diemSoMinigame2.point == 7)
        {
            speedNPC = 5f;
        }
        if (diemSoMinigame2.point == 15)
        {
            speedNPC = 7f;
        }
        if (diemSoMinigame2.point == 25)
        {
            speedNPC = 10f;
        }
        if (diemSoMinigame2.point == 30)
        {
            speedNPC = 12f;
        }
        if (diemSoMinigame2.point == 35)
        {
            speedNPC = 15f;
        }
        transform.position = Vector2.MoveTowards(transform.position, startPosition + new Vector2(-60f, 0f), speedNPC * Time.deltaTime);
    }
}
