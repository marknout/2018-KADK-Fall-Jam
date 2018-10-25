using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D RB;

    public float ForwardForce = 200f;
    public float JumpForce = 500f;
    public bool JumpCheck = true;
    public Animator anim;

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

        if (Input.GetKey("right") || Input.GetKey("d"))
        {

            //RB.AddForce(ForwardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            RB.AddForce(new Vector2(ForwardForce * Time.deltaTime, 0), ForceMode2D.Impulse);
            transform.localScale = new Vector3(1, 1, 1);


        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {

            //RB.AddForce(-ForwardForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
            RB.AddForce(new Vector2(-ForwardForce * Time.deltaTime, 0), ForceMode2D.Impulse);
            transform.localScale = new Vector3(-1, 1, 1);

        }

        if (Input.GetKey("space") && JumpCheck == true)
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
