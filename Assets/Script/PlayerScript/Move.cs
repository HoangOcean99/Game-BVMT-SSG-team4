
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rd2d;
    public GameObject mainPlayer;
    public int controller = 0;

    public float leftorRight;
    public float upOrDown;
    private float speedMove = 5f;
    private Animator ator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        ator = rd2d.GetComponent<Animator>();
        
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
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                leftorRight = -1;
                mainPlayer.transform.localScale = new Vector2(-1, transform.localScale.y);
                ator.SetInteger("Move", 1); 

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
