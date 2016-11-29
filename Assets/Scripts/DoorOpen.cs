using UnityEngine;
using System.Collections; 
using System.Collections.Generic; 

public class DoorOpen : MonoBehaviour 
{
    public float smooth = 2.0f;
    public float DoorOpenAngleLFT = 90.0f;
	public float DoorOpenAngleRGT = -90.0f;
	public float SecAfterLaught = 1.5f;
    
	public Transform LeftHinges;
	public Transform RightHinges;
	public Transform DoorLight;
	
	float DoorCloseAngle = 0.0f;
    bool open;
	AudioSource audio;
	AudioSource laught;
	bool playLaught=false;
	float laughtSecCounter=0;
	bool laughtPlayed=false;
	SwampScript gostSwamps;
	SwampController swampsController;
	
	void Start(){
		audio = gameObject.GetComponent<AudioSource>();
		laught = GameObject.Find("Laught").GetComponent<AudioSource>();
		gostSwamps = GameObject.Find("Swamp").GetComponent<SwampScript>();
		swampsController = GameObject.Find("Controller").GetComponent<SwampController>();
	}
	
    void Update()
    {
        if(open == true)
        {
            var targetLft = Quaternion.Euler (0, DoorOpenAngleLFT, 0);
			var targetRgt = Quaternion.Euler (0, DoorOpenAngleRGT, 0);
            LeftHinges.localRotation = Quaternion.Slerp(LeftHinges.localRotation, targetLft, Time.deltaTime * smooth);
			RightHinges.localRotation = Quaternion.Slerp(RightHinges.localRotation, targetRgt, Time.deltaTime * smooth);
        }

        if(open == false)
        {
            var target1= Quaternion.Euler (0, DoorCloseAngle, 0);
            LeftHinges.localRotation = Quaternion.Slerp(LeftHinges.localRotation, target1, Time.deltaTime * smooth);
			RightHinges.localRotation = Quaternion.Slerp(RightHinges.localRotation, target1, Time.deltaTime * smooth);
        }   
		
		if(playLaught && SecAfterLaught>laughtSecCounter){
				laughtSecCounter += 1 * Time.deltaTime;
		}
		
		if(laughtSecCounter>=SecAfterLaught && !laughtPlayed){
			laught.Play();
			laughtPlayed=true;
			gostSwamps.Activate();
			swampsController.isTimerOn = true;
		}
    }
	
	public void Open(){
		audio.Play();
		open=true;
		DoorLight.GetComponent<Light>().enabled = true;
		playLaught = true;
	}
	
	public void Close(){
		audio.Play();
		open=false;
		DoorLight.GetComponent<Light>().intensity = 0;
		DoorLight.GetComponent<Light>().enabled = false;
	}
}
