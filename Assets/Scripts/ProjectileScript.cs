using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	
	public float life = 2.0f;
	
	void Update () {
		if(this.GetComponent<Rigidbody>().IsSleeping()){
			Destroy(this.gameObject,life);
		}
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.collider.tag == "Terrain" || collision.collider.tag == "Wall" || collision.collider.tag == "Evironment"){
			Destroy(this.gameObject);
		}
	}	
}
