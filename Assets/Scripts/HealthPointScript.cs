using UnityEngine;
using System.Collections;

public class HealthPointScript : MonoBehaviour {
	
	public bool isOn=true;
	public Texture onTexture;
	public Texture offTexture;
	
	public void ChangeState(){
		isOn = !isOn;	
		
		if(isOn){
			this.GetComponent<GUITexture>().texture = onTexture;
		}else{
			this.GetComponent<GUITexture>().texture = offTexture;	
		}
	}
}
