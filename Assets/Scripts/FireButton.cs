using UnityEngine;
using System.Collections;

public class FireButton : MonoBehaviour {
	AnimationController PlayerAnimController;
	public BasicTrajectorySimulation trajectory;
	public Transform projectile;
	public Transform player;
	public Transform FireCamera;
	public Transform CameraOffset;
	
	private float _OrizForce = 0;
	private float _VertForce = 0;
	
	public float spawnDistance = 1.0f;
	public float spawhHeight = 2.0f;
	public float startForce = 200.0f;
	public float Torque = 50000.0f;
	public float Increment = 100f;
	
	public float OrizForce {
		get{return _OrizForce;}
	}
	
	public float VertForce {
		get{return _VertForce;}
	}
	
	void Start () {
		PlayerAnimController = GameObject.Find("Player").GetComponent<AnimationController>();
		this._OrizForce = startForce;
		this._VertForce = startForce;
		trajectory.isOn=false;
	}
	
	void Update () {
		if(Input.touchCount > 0)
    	{
			foreach(Touch touch in Input.touches){
		        if(/*touch.phase == TouchPhase.Began &&*/ this.GetComponent<GUITexture>().HitTest(touch.position))
		        {
					PlayLoad();
	         	} 
				if(touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
				{
					PlayLancio();	
				}
			}
		}
		
		if(Input.GetKeyUp("q")){
			//PlayFire();
			PlayLancio();
		}
		
		if(Input.GetButton ("Fire1") && this.GetComponent<GUITexture>().HitTest(Input.mousePosition)){
			PlayLoad();
		}
		
		if(Input.GetMouseButtonUp(0) && this.GetComponent<GUITexture>().HitTest(Input.mousePosition)){
			PlayLancio();
		}
	}
	
	void PlayLoad()
	{
		//Camera.main.transform.parent = FireCamera;
		trajectory.isOn=true;
		iTween.MoveTo(Camera.main.gameObject,iTween.Hash("oncomplete","ZoomInCompleted","oncompletetarget",this.gameObject,"position",FireCamera.position,"easetype",iTween.EaseType.easeInSine,"time",1f));
		iTween.RotateTo(Camera.main.gameObject,iTween.Hash("rotation",player.rotation.eulerAngles,"easetype",iTween.EaseType.easeInSine,"time",1f));
		
		this._OrizForce += Increment * Time.deltaTime;	
		this._VertForce += Increment * Time.deltaTime;
	}
	
	void ZoomInCompleted(){
		Camera.main.transform.parent = FireCamera;
	}
	
	/*void PlayFire(){
		GameObject bullett = (Instantiate(projectile,player.position + (player.forward * spawnDistance) + (player.up * spawhHeight),player.rotation) as Transform).gameObject;
		bullett.transform.rigidbody.AddForce(player.forward * _OrizForce,ForceMode.Impulse);
		bullett.transform.rigidbody.AddForce(player.up * _VertForce,ForceMode.Impulse);
		bullett.rigidbody.AddTorque(new Vector3(Random.value,Random.value,Random.value) * Torque);
	}*/
	
	void PlayLancio()
	{
		trajectory.isOn=false;
		
		iTween.MoveTo(Camera.main.gameObject,iTween.Hash("oncomplete","ZoomOutCompleted","oncompletetarget",this.gameObject,"position",CameraOffset.position,"easetype",iTween.EaseType.easeInSine,"time",1f));
		iTween.RotateTo(Camera.main.gameObject,iTween.Hash("rotation",CameraOffset.rotation.eulerAngles,"easetype",iTween.EaseType.easeInSine,"time",1f));
		
		PlayerAnimController.PlayLancio();
		player.GetComponent<PlayerController>().RotateToAttack();
		
		Camera.main.transform.parent = CameraOffset;
		
		//Camera.main.transform.position = new Vector3(0,0,0);
		//Camera.main.transform.rotation= new Quaternion(0,0,0,0);
		//Camera.main.transform.localScale= new Vector3(1,1,1);
	}
	
	public void ExecLancio(){
		GameObject bullett = (Instantiate(projectile,player.position + (player.forward * spawnDistance) + (player.up * spawhHeight),player.rotation) as Transform).gameObject;
		bullett.transform.GetComponent<Rigidbody>().AddForce(player.forward * _OrizForce,ForceMode.Acceleration);
		bullett.transform.GetComponent<Rigidbody>().AddForce(player.up * _VertForce,ForceMode.Acceleration);
		bullett.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.value,Random.value,Random.value) * Torque);
		this._OrizForce = startForce;
		this._VertForce = startForce;
	}
    
}