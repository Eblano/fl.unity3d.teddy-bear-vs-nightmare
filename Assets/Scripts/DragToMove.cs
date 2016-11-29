using UnityEngine;
using System.Collections;

public class DragToMove : MonoBehaviour {
	
	public Vector3 targetPosition;
	public float Speed = 4; 
	public bool isActive = true;
	public Transform cameraFixed;
	
	CharacterController player;
	Plane targetPlane;
	
	void Start(){
		player = GameObject.Find("Player").GetComponent<CharacterController>();
		targetPlane = new Plane( Vector3.up, 0);
	}
	
	void Update () {
		/*if(isActive && cameraFixed.gameObject.active){
			if(Input.GetMouseButton(0)){
				RaycastHit hit = new RaycastHit();
				Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast (cameraRay.origin,cameraRay.direction,out hit, 100)) {
					Vector3 diff = transform.TransformDirection(hit.point - player.transform.position);
					
					Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
					float dist =0;
					if(targetPlane.Raycast(ray, out dist)){
						var pos = ray.GetPoint(dist);
						player.transform.LookAt(pos, Vector3.up);
					}
					
					diff.Normalize();
					player.Move(diff * Speed * Time.deltaTime);
				}
			}
		}*/
	}
}
