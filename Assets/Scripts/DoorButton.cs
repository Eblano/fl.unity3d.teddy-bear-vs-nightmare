using UnityEngine;
using System.Collections;

public class DoorButton : MonoBehaviour {
	
	public Transform Vapor;
	public Transform Shockwave;
	public Transform LightUp;
	public Transform LightDown;
	public float DownSpeed;
	public AudioClip MovingSound;
	public AudioClip EndSound;
	
	private bool isPressed = false;
	private AudioSource audio;
	private bool isEnded;
	private DoorOpen doorScrpit;
	//private ShakeCamera camShake;
	
	// Use this for initialization
	void Start () {
		audio = this.GetComponent<AudioSource>();
		doorScrpit = GameObject.Find("Door").GetComponent<DoorOpen>();
		//camShake = GameObject.Find("CameraFixed").GetComponent<ShakeCamera>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isPressed){
			if(this.transform.position.y > -0.28){
				Vector3 temp = this.transform.position;
				temp.y -= DownSpeed * Time.deltaTime;
				this.transform.position = temp;
			}else{
				if(!isEnded){
					isEnded=true;
					audio.clip = EndSound;
					audio.Play();
					//camShake.Shake("z",-0.1f,1);
					Shockwave.GetComponent<ParticleSystem>().Play();
					doorScrpit.Open();
				}
			}
		}
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		//print(col.name);
		if(col.name == "Player" && !isPressed){
			Pressed();
			isPressed = true;
		}
	}
	
	/*void OnCollisionEnter(Collision col){
		print (col.gameObject.name);
		if(col.gameObject.name == "PlayerGround" && !isPressed){
			Pressed();
			isPressed = true;
		}
	}*/
	
	void Pressed(){
		Vapor.GetComponent<ParticleEmitter>().emit=false;
		audio.clip = MovingSound;
		audio.Play();
		LightUp.GetComponent<Light>().enabled=false;
		LightDown.GetComponent<Light>().enabled=false;
	}
}
