using UnityEngine;
using System.Collections;

public class DoorLight : MonoBehaviour {
	
	public float maxIntensity = 4.0f;
	public float minIntensity = 0.5f;
	public float speed = 2.0f;
	
	Light light;
	bool increase=true;
	
	// Use this for initialization
	void Start () {
		light = gameObject.GetComponent<Light>();
		light.intensity = 0;//minIntensity;
	}
	
	// Update is called once per frame
	void Update () {
		if(light.enabled){
			if (increase){
			    //light.intensity=Mathf.Lerp(light.intensity,maxIntensity,speed*Time.deltaTime);	
				light.intensity = light.intensity + speed*Time.deltaTime;
			}else{
				//light.intensity=Mathf.Lerp(light.intensity,minIntensity,speed*Time.deltaTime);	
				light.intensity = light.intensity - speed*Time.deltaTime;
			}
		
			if(light.intensity > maxIntensity - 0.01f){
				//decresce
				increase = false;
			}
			
			if (light.intensity < minIntensity + 0.01f){
				//cresce
				increase = true;
			}
		}
	}
}

	