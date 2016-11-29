using UnityEngine;
using System.Collections;

public class FollowTransform : MonoBehaviour {

	public Transform targetTransform;
	public bool faceForward = false;
	public float targetHeight = 1.2f;
	
	private Transform thisTransform;
	
	void Start(){
		
		thisTransform = transform;
		
	}
	
	void Update() {
	
		thisTransform.position = targetTransform.position;
		this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y + targetHeight,this.transform.position.z);
		
		if(faceForward){
			thisTransform.forward = targetTransform.forward;	
		}
		
	}
}
