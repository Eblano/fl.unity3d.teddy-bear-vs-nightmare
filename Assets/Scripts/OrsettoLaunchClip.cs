using UnityEngine;
using System.Collections;

public class OrsettoLaunchClip : MonoBehaviour {
	
	public FireButton fire;
	
	// Use this for initialization
	void Start () {
		//fire = GameObject.Find("Attack").GetComponent<FireButton>();
	}
	
	public void OnLancio(){
		fire.ExecLancio();	
	}
}
