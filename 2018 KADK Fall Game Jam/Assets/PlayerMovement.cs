using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody RB;

    public float ForwardForce = 200f;
    public float JumpForce = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {

        if (Input.GetKey("right") || Input.GetKey("d"))
        {

            RB.AddForce(ForwardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {

            RB.AddForce(-ForwardForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("space"))
        {

            RB.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);

        }

    }
}
