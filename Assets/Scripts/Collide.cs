using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	// this script pushes all rigidbodies that the character touches
	public float pushPower = 10.0f;
	 
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		Rigidbody body = hit.collider.attachedRigidbody;
		
	    // no rigidbody
	    if (body == null || body.isKinematic) { return; }
	 
		//print (hit.gameObject.name);
		
	    // We dont want to push objects below us
	    if (hit.moveDirection.y < -0.3) { return; }
	 
		
		
	    // Calculate push direction from move direction,
	    // we only push objects to the sides never up and down
	    var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
	 
	    // If you know how fast your character is trying to move,
	    // then you can also multiply the push velocity by that.
	 
	    // Apply the push
	    body.velocity = pushDir * pushPower;
	}
}
