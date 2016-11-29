using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private HealthManagerScript healthManager;
	private Transform _target;
	private Transform weapon;
	private Transform head;
	
	public Transform Target {
		get{return _target;}
	}
	// the frequency with which to re-scane for new nearest target in seconds 
	// (set in inspector)
	public float scanFrequency = 2.0f;
	// the tag to search for (set this value in the inspector)
	public string searchTag = "Enemy";
	public Transform BloodFountain;
	public Transform BloodPuddle;
	
	void Start () {
		//weapon = ((GameObject) GameObject.FindGameObjectWithTag("Weapon")).transform;
		healthManager = GameObject.Find("HealthManager").GetComponent<HealthManagerScript>();
		/*foreach(Transform t in GetComponentsInChildren<Transform>()){
			if(t.name =="testa"){
				head = t;	
				break;
			}
		}*/
		 // set up repeating scan for new targets:
    	//InvokeRepeating("ScanForTarget", 0, scanFrequency );
	}
	
	void Update () {
		// we rotate to look at the target every frame (if there is one)
	    if (_target != null) {
	        if(_target.transform.position.y + 2 > this.transform.position.y){
				//azzera Y per rotazione orsetto, usa y per alzo arma e testa
				float y = _target.transform.position.y;
				Vector3 bodyPos = new Vector3(_target.transform.position.x,0,_target.transform.position.z);
				
				
				transform.LookAt(bodyPos);
				//weapon.LookAt(_target);
				//head.LookAt(_target);
			}else{
				transform.LookAt(_target);
			}
	    }
	}
	
	public void Hit(GameObject Enemy){
		if(Enemy.name.Contains("SpiderEnemy")){
			healthManager.RemoveHealth(1);
			Vector3 bloodPos = new Vector3(this.transform.position.x,2,this.transform.position.z);
			Instantiate(BloodFountain,bloodPos,Quaternion.identity);
			Instantiate(BloodPuddle,this.transform.position,Quaternion.identity);
		}
	}
	
	public void RotateToAttack(){
		ScanForTarget();
	}
	
	void ScanForTarget() {
	    // this should be called less often, because it could be an expensive
	    // process if there are lots of objects to check against
	    _target = GetNearestTaggedObject();
	}
 

 
    Transform GetNearestTaggedObject()  {
	    // and finally the actual process for finding the nearest object:
	 
	    float nearestDistanceSqr = Mathf.Infinity;
	    GameObject[] taggedGameObjects = GameObject.FindGameObjectsWithTag(searchTag); 
	    Transform nearestObj = null;
	 
	    // loop through each tagged object, remembering nearest one found
	    foreach (GameObject obj in taggedGameObjects) {
	 
	        Vector3 objectPos = obj.transform.position;
	        float distanceSqr = (objectPos - transform.position).sqrMagnitude;
	 
	        if (distanceSqr < nearestDistanceSqr) {
	            nearestObj = obj.transform;
	            nearestDistanceSqr = distanceSqr;
	        }
	    }
	 
	    return nearestObj;
	}
}