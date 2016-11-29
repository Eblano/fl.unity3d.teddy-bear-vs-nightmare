using UnityEngine;
using System.Collections;

public class CameraTypeSelector : MonoBehaviour {
	
	private bool isFixedEnabled = false;
	private bool isRelativeEnabled = true;
	public GameObject Player;
	public GameObject CameraPivot;
	public GameObject CameraFollow;
	
	void Start(){
		Player = GameObject.Find("Player");
		//CameraPivot = GameObject.Find("CameraPivot");
		//CameraFollow = GameObject.Find("CameraFollow");
	}
	
	public void ActivateFixed(){
		
		if(isFixedEnabled == false){
			
			CameraFollow.SetActiveRecursively(true);
			(Player.GetComponent("PlayerRelativeControl") as MonoBehaviour).enabled = true;
			
			CameraPivot.SetActiveRecursively(false);
			(Player.GetComponent("CameraRelativeControl") as MonoBehaviour).enabled = false;
		
			isFixedEnabled = true;
			isRelativeEnabled = false;
		}
	}
	
	public void ActivateRelative(){
		
		if(isRelativeEnabled == false){
			
			CameraPivot.SetActiveRecursively(true);
			(Player.GetComponent("CameraRelativeControl") as MonoBehaviour).enabled = true;
			
			CameraFollow.SetActiveRecursively(false);
			(Player.GetComponent("PlayerRelativeControl") as MonoBehaviour).enabled = false;
		
			/*isFixedEnabled = true;
			isRelativeEnabled = false;*/
		
			isFixedEnabled = false;
			isRelativeEnabled = true;
		}
	}
	
	
}
