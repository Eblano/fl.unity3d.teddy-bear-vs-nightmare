using UnityEngine;
using System.Collections;

public class DebugScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//print(Camera.mainCamera.name);
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<GUIText>().text = Screen.width +" : " + Screen.height;
	}
}
