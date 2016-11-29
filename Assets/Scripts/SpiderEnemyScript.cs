using UnityEngine;
using System.Collections;

public class SpiderEnemyScript : MonoBehaviour {
	
	public float speed = 3.0f;
	public float playerHittedRecoil = 10.0f;
	public Transform explosionEffect;
	
	private Transform player;
	private SwampController controller;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		controller = GameObject.Find("Controller").GetComponent<SwampController>();
	}
	
	void FixedUpdate(){
		LookAtPlayer();
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * speed * Time.deltaTime);	
	}
	
	void LookAtPlayer(){
		Vector3 lookAtPosition = new Vector3(player.position.x,0,player.position.z);
		this.transform.LookAt(lookAtPosition);
	}
	
	public void Kill(){
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Projectile")
		{
			controller.KillEnemy(this.gameObject);
			explosionEffect.GetComponent<ParticleSystem>().startColor = new Color(Random.Range(0,255),Random.Range(0,255),Random.Range(0,255));
			Instantiate(explosionEffect,collision.contacts[0].point,Quaternion.identity);
			
			Kill ();	
		}
		if(collision.gameObject.tag == "Player"){
			player.GetComponent<PlayerController>().Hit(this.gameObject);
			GetComponent<Rigidbody>().AddForce( (-this.transform.forward) * playerHittedRecoil,ForceMode.Impulse);
		}
	}
}
