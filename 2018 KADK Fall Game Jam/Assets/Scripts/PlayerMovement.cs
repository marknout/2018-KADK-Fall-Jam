using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D RB;

    public float ForwardForce = 200f;
    public float forwardTransform = 200f;
    public float JumpForce = 500f;
    public bool JumpCheck = true;
    public Animator anim;
    public bool autoMove;
    Vector3 oldPos;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}

    void Update()
    {
        anim.SetFloat("horSpeed", Mathf.Abs(RB.velocity.x));
    }

    // Update is called once per frame
    void FixedUpdate() {

        if (autoMove)
        {
            TranslateHorizontal(1);
        }
        else
        {
            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                MoveHorizontal(1);
            }

            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                MoveHorizontal(-1);
            }

            if (Input.GetKey("space") && JumpCheck == true)
            {
                Jump();

            }
        }

        if (oldPos.x == transform.position.x)
        {
            anim.SetBool("walking", false);
        }
        else
        {
            anim.SetBool("walking", true);
        }
        oldPos = transform.position;
    }

    private void MoveHorizontal(int direction)
    {
        RB.AddForce(new Vector2(ForwardForce * direction * Time.deltaTime, 0), ForceMode2D.Impulse);
        transform.localScale = new Vector3(direction, 1, 1);
    }

    private void TranslateHorizontal(int direction)
    {
        transform.Translate(new Vector3(forwardTransform * direction * Time.deltaTime, 0, 0));
        transform.localScale = new Vector3(direction, 1, 1);
    }

    public void Jump()
    {
        if (JumpCheck == true)
        {
            RB.AddForce(new Vector2(0, JumpForce * Time.deltaTime), ForceMode2D.Impulse);
            //RB.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            JumpCheck = false;
            anim.SetBool("jumping", true);
        }
    }

    void OnCollisionEnter2D(Collision2D CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "JumpStart")
        {
            JumpCheck = true;
            anim.SetBool("jumping", false);
        }
    }
}
