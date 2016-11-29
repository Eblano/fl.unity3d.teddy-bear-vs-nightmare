using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	
	public enum Cameras{
		Fixed = 1,
		Relative = 2
	}
	
	CameraTypeSelector cameraSelector;
	public Cameras currentCamera = Cameras.Relative;
	public Texture RelativeTexture;
	public Texture FixedTexture;
	
	private GUITexture switchTexture;
	
		
	// Use this for initialization
	void Start () {
		switchTexture = this.GetComponent<GUITexture>();
		switchTexture.texture = RelativeTexture;
		cameraSelector = GameObject.Find ("CameraControls").GetComponent<CameraTypeSelector>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey("r")){
			if(currentCamera != Cameras.Relative){
				cameraSelector.ActivateRelative();
				currentCamera = Cameras.Relative;
				switchTexture.texture = RelativeTexture;
			}
		}
		
		if(Input.GetKey("f")){
			if(currentCamera != Cameras.Fixed){
				cameraSelector.ActivateFixed();
				currentCamera = Cameras.Fixed;
				switchTexture.texture = FixedTexture;
			}
		}
		
		if(Input.touchCount > 0)
    	{
			foreach(Touch touch in Input.touches){
		        if(touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
		        {
					if(currentCamera == Cameras.Fixed){
						cameraSelector.ActivateRelative();
						currentCamera = Cameras.Relative;
						switchTexture.texture = RelativeTexture;
					}
					if(currentCamera == Cameras.Relative){
						cameraSelector.ActivateFixed();
						currentCamera = Cameras.Fixed;
						switchTexture.texture = FixedTexture;
					}
	         	} 
			}
	    }
		
		if(Input.GetMouseButtonDown(0) && GetComponent<GUITexture>().HitTest(Input.mousePosition)){
			if(currentCamera == Cameras.Fixed){
				cameraSelector.ActivateRelative();
				currentCamera = Cameras.Relative;
				switchTexture.texture = RelativeTexture;
			}else if(currentCamera == Cameras.Relative){
				cameraSelector.ActivateFixed();
				currentCamera = Cameras.Fixed;
				switchTexture.texture = FixedTexture;
			}
		}
		
	}
}
