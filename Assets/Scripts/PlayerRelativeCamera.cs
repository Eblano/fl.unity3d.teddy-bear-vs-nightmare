// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class PlayerRelativeCamera : MonoBehaviour {


public Joystick moveJoystick;
public Joystick rotateJoystick;

public Transform cameraTransform;
public Transform cameraPivot;

public float speed = 6;
public Vector2 rotationSpeed = new Vector2(50,25);

private Transform thisTransform;
private CharacterController character;

void  Start (){

	thisTransform = GetComponent<Transform>();
	character = GetComponent<CharacterController>();

}

void  Update (){

	Vector3 movement= cameraTransform.TransformDirection(new Vector3(moveJoystick.position.x,0,moveJoystick.position.y));
	movement.y = 0;
	movement.Normalize();
	
	Vector2 absJoyPos= new Vector2(Mathf.Abs(moveJoystick.position.x),Mathf.Abs(moveJoystick.position.y));
	movement *= speed * ((absJoyPos.x > absJoyPos.y) ? absJoyPos.x : absJoyPos.y);
	movement *= Time.deltaTime;
	
	character.Move(movement);	

	FaceMovementDirection();
	
	Vector2 camRotation= rotateJoystick.position;
	camRotation.x *= rotationSpeed.x;
	camRotation.y *= rotationSpeed.y;
	camRotation *= Time.deltaTime;
	cameraPivot.Rotate(0,camRotation.x,0,Space.World);
	cameraPivot.Rotate(camRotation.y,0,0);
}

void  FaceMovementDirection (){

	Vector3 horizontalVelocity = character.velocity;
	horizontalVelocity.y = 0;
	
	if(horizontalVelocity.magnitude > 0.1f){
		thisTransform.forward = horizontalVelocity.normalized;
	}
	
}
}