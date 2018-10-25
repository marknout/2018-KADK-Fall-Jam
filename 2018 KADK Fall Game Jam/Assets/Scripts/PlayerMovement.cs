using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D RB;

    public float ForwardForce = 200f;
    public float JumpForce = 500f;
    public bool JumpCheck = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {

        if (Input.GetKey("right") || Input.GetKey("d"))
        {

            //RB.AddForce(ForwardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            RB.AddForce(new Vector2(ForwardForce * Time.deltaTime, 0), ForceMode2D.Impulse);


        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {

            //RB.AddForce(-ForwardForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
            RB.AddForce(new Vector2(-ForwardForce * Time.deltaTime, 0), ForceMode2D.Impulse);

        }

        if (Input.GetKey("space") && JumpCheck == true)
        {

            RB.AddForce(new Vector2(0, JumpForce * Time.deltaTime), ForceMode2D.Impulse);
            //RB.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            JumpCheck = false;

        }

    }

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "JumpStarter")
        {
            JumpCheck = true;
        }

    }
}
