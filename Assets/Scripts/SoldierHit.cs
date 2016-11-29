using UnityEngine;
using System.Collections;

public class SoldierHit : MonoBehaviour {

    public GameObject soldierRagdoll;
    public GameObject soldier;
	public float KickedForce = 100;
	
    Collider thisCollider;
	
	int breaks = 0;
	
    void Start()
    {
        thisCollider = this.GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "Terrain")
        {
			if(breaks==0){
				//Debug.Break();
				breaks++;
			}
			
            soldier.SetActive(false);
            soldierRagdoll.SetActive(true);
            thisCollider.isTrigger = true;
        }
    }
}
