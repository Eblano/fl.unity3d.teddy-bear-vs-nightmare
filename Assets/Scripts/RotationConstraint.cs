// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class RotationConstraint : MonoBehaviour {
//////////////////////////////////////////////////////////////
// RotationConstraint.js
// Penelope iPhone Tutorial
//
// RotationConstraint constrains the relative rotation of a 
// Transform. You select the constraint axis in the editor and 
// specify a min and max amount of rotation that is allowed 
// from the default rotation
//////////////////////////////////////////////////////////////

public enum ConstraintAxis
{
	X = 0,
	Y = 1,
	Z = 2
}

public int axis; 			// Rotation around this axis is constrained
public float min;						// Relative value in degrees
public float max;						// Relative value in degrees
private Transform thisTransform;
private Vector3 rotateAround;
private Quaternion minQuaternion;
private Quaternion maxQuaternion;
private float range;

void  Start (){
	thisTransform = transform;
	
	// Set the axis that we will rotate around
	switch ( axis )
	{
		case 0: //X
			rotateAround = Vector3.right;
			break;
			
		case 1: //Y
			rotateAround = Vector3.up;
			break;
			
		case 2: //Z
			rotateAround = Vector3.forward;
			break;
	}
	
	// Set the min and max rotations in quaternion space
	Quaternion axisRotation= Quaternion.AngleAxis( thisTransform.localRotation.eulerAngles[ axis ], rotateAround );
	minQuaternion = axisRotation * Quaternion.AngleAxis( min, rotateAround );
	maxQuaternion = axisRotation * Quaternion.AngleAxis( max, rotateAround );
	range = max - min;
}

// We use LateUpdate to grab the rotation from the Transform after all Updates from
// other scripts have occured
void  LateUpdate (){
	// We use quaternions here, so we don't have to adjust for euler angle range [ 0, 360 ]
	Quaternion localRotation= thisTransform.localRotation;
	Quaternion axisRotation= Quaternion.AngleAxis( localRotation.eulerAngles[ axis ], rotateAround );
	float angleFromMin= Quaternion.Angle( axisRotation, minQuaternion );
	float angleFromMax= Quaternion.Angle( axisRotation, maxQuaternion );
		
	if ( angleFromMin <= range && angleFromMax <= range )
		return; // within range
	else
	{		
		// Let's keep the current rotations around other axes and only
		// correct the axis that has fallen out of range.
		Vector3 euler= localRotation.eulerAngles;			
		if ( angleFromMin > angleFromMax )
			euler[ axis ] = maxQuaternion.eulerAngles[ axis ];
		else
			euler[ axis ] = minQuaternion.eulerAngles[ axis ];

		thisTransform.localEulerAngles = euler;		
	}
}

}