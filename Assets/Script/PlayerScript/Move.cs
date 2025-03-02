using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rd2d;
    public GameObject mainPlayer;
    public int controller = 0;

    private float leftorRight;
    private float upOrDown;
    private float speedMove = 5f;
    private Animator ator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (rd2d.GetComponent<Collider2D>() == null)
        {
            rd2d.gameObject.AddComponent<BoxCollider2D>(); // Thêm BoxCollider2D nếu chưa có
        }
        ator = rd2d.GetComponent<Animator>();
        rd2d.isKinematic = false;
        rd2d.gravityScale = 0; // Nếu không muốn bị rơi
        rd2d.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == 1)
        {
            ator.SetInteger("Move", 0);
            leftorRight = 0;
            upOrDown = 0;
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                leftorRight = 1;
                mainPlayer.transform.localScale = new Vector2(1, transform.localScale.y);
                ator.SetInteger("Move", 1);
                Debug.Log("D");
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                leftorRight = -1;
                mainPlayer.transform.localScale = new Vector2(-1, transform.localScale.y);
                ator.SetInteger("Move", 1); 
                Debug.Log("A");

            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                upOrDown = 1;
                //transform.localScale = new Vector2(1, transform.localScale.y);
                ator.SetInteger("Move", 3);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                upOrDown = -1;
                //transform.localScale = new Vector2(-1, transform.localScale.y);
                ator.SetInteger("Move", 2);
            }
            rd2d.velocity = new Vector2(leftorRight * speedMove, rd2d.velocity.y);
            rd2d.velocity = new Vector2(rd2d.velocity.x, speedMove * upOrDown);
            Debug.Log("hello");
        }
        if (controller == 2)
        {
            ator.SetInteger("Move", 0);
            upOrDown = 0;

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                upOrDown = 1;
                //transform.localScale = new Vector2(1, transform.localScale.y);
                ator.SetInteger("Move", 3);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                upOrDown = -1;
                //transform.localScale = new Vector2(-1, transform.localScale.y);
                ator.SetInteger("Move", 2);
            }
            rd2d.velocity = new Vector2(rd2d.velocity.x, speedMove * upOrDown);
        }
    }
}
