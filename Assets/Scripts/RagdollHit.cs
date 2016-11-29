using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RagdollHit : MonoBehaviour {
	
	public float force = 30f; 
	
	private List<Rigidbody> RagdollRigidbody = new List<Rigidbody>();
	
	void Awake()
	{
		/*SoldierHit scr = GameObject.Find("Soldier").transform.GetComponent<SoldierHit>();
		foreach(Rigidbody child in this.GetComponentsInChildren<Rigidbody>()){
			RagdollRigidbody.Add(child);	
		}*/
	}
	
	void OnCollisionEnter(Collision collision)
    {
		if(collision.collider.name=="piede-dx"){
			Vector3 dir = new Vector3(-collision.relativeVelocity.x,-collision.relativeVelocity.y,-collision.relativeVelocity.z);
			this.GetComponent<Rigidbody>().velocity = dir * force;
		}
	}
}
