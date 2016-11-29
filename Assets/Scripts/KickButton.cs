using UnityEngine;
using System.Collections;

public class KickButton : MonoBehaviour {
	
	Collider kickCollider;
	AnimationController PlayerAnimController;
	
	// Use this for initialization
	void Start () {
		PlayerAnimController = GameObject.Find("Player").GetComponent<AnimationController>();
		//GameObject piede = GameObject.Find("piede-dx");
		//kickCollider = piede.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0)
    	{
			foreach(Touch touch in Input.touches){
		        if(touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
		        {
					PlayKick();
	         	} 
			}
		}
		
		if(Input.GetKey("q")){
			PlayKick();
		}
		
		if(Input.GetMouseButtonDown(0) && GetComponent<GUITexture>().HitTest(Input.mousePosition)){
			PlayKick();
		}
	}
	
	void PlayKick(){
		//kickCollider.isTrigger=false;
		PlayerAnimController.PlayAttacco2();
	}
}
