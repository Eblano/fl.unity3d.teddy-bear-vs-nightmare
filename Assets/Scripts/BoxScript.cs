using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

	AudioSource audio;
	
	void Start(){
		audio = this.GetComponent("AudioSource") as AudioSource;	
	}
	
	void OnCollisionEnter(Collision collision) 
	{
		if(collision.impactForceSum.magnitude>0.5){
			audio.Play();
		}
		
	}
}
