using UnityEngine;

public class SortingLayerObject : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRender.sortingOrder = Mathf.RoundToInt(-transform.position.y);
    }
}
