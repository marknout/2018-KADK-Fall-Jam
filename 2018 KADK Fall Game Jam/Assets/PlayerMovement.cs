using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody RB;

    public float ForwardForce = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {

        RB.AddForce(ForwardForce * Time.deltaTime, 0,0);

	}
}
