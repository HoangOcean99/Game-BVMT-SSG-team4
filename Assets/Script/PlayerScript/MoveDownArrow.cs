using UnityEngine;

public class MoveDownArrow : MonoBehaviour
{
    public float speed = 5f;
    public float height = 0.2f;
    private Rigidbody2D rb;
    private Vector2 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = rb.position;
    }

    void FixedUpdate()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * height;
        rb.MovePosition(new Vector2(rb.position.x, newY));
    }
}
