// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class PlayerRelativeControl : MonoBehaviour {
//////////////////////////////////////////////////////////////
// PlayerRelativeControl.js
// Penelope iPhone Tutorial
//
// PlayerRelativeControl creates a control scheme similar to what
// might be found in a 3rd person, over-the-shoulder game found on
// consoles. The left stick is used to move the character, and the
// right stick is used to rotate the character. A quick double-tap
// on the right joystick will make the character jump.
//////////////////////////////////////////////////////////////

// This script must be attached to a GameObject that has a CharacterController
public Joystick moveJoystick;

public Transform cameraFollow;						// The transform used for camera rotation

public float forwardSpeed = 4;
public float backwardSpeed = 4;
public float rotationSpeed = 150;	// Camera rotation speed for each axis

private Transform thisTransform;
private CharacterController character;
private Vector3 velocity;						// Used for continuing momentum while in air

void  Start (){
	// Cache component lookup at startup instead of doing this every frame		
	thisTransform = GetComponent< Transform >();
	character = GetComponent< CharacterController >();	
}

void  Update (){
	Vector3 movement= thisTransform.TransformDirection(new Vector3(0,0,moveJoystick.position.y));
	movement.y = 0;
	movement.Normalize();
	

	// Apply movement from move joystick
	Vector2 absJoyPos= new Vector2( Mathf.Abs( moveJoystick.position.x ), Mathf.Abs( moveJoystick.position.y ) );	
	if ( absJoyPos.y > absJoyPos.x )
	{
		if ( moveJoystick.position.y > 0 )
		{
			movement *= forwardSpeed * absJoyPos.y;
		}
		else
		{
			movement *= backwardSpeed * absJoyPos.y;
		}
	}
	else if(absJoyPos.y<absJoyPos.x)
	{
		//rotation
		
		Vector2 camRotation= moveJoystick.position;
		camRotation.x *= rotationSpeed;
		camRotation *= Time.deltaTime;
		
		character.transform.Rotate( 0, camRotation.x, 0, Space.World );
	}
	
		
	movement += velocity;	
	movement += Physics.gravity;
	movement *= Time.deltaTime;
	
	// Actually move the character	
	character.Move( movement );
}

}