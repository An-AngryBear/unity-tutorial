
using UnityEngine;

public class playermovement : MonoBehaviour {

    // this is a reference to the Rigidbody compnonent called "rb"
    public Rigidbody rb;
	
	// We Marked this as "Fixed Update beause we are using it to mess with physics
	void FixedUpdate () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Add a force of 2000 on the z-axis
	}
}
