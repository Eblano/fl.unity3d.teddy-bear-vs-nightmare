using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SwampController : MonoBehaviour {
	
	public GameObject SpiderEnemy;
	public float maxEnemies = 5.0f;
	public float timeBetweenEnemies = 15.0f;
	public bool isTimerOn;
	
	private List<GameObject> Swamp; 
	private float timeToNextEnemy = 0.0f;
	
	// Use this for initialization
	void Start () {
		Swamp = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isTimerOn){
			if(Time.time>timeToNextEnemy){
				if(Swamp.Count == maxEnemies){
					isTimerOn=false;
				}else{
					DropEnemy();
				}
			}
		}
		
		print("Enemy count: "+ Swamp.Count);
	}
	
	public void StartSwamp(){
		timeToNextEnemy = Time.time;
		isTimerOn = true;	
	}
	
	public void DropEnemy(){
		timeToNextEnemy += timeBetweenEnemies;
		
		Vector3 position = new Vector3(Random.Range(-24,20),0,Random.Range(-31,14));
		
		
		//todo controlli: 
		//	è troppo vicino al giocatore? 
		//	è troppo vicino ad altri nemici? 
		//	collide con qualcosa?
		
		Object o = Instantiate(SpiderEnemy,position,Quaternion.identity);
		Transform t = o as Transform;
			GameObject temp = o as GameObject;
			
			Swamp.Add(temp);
	}
	
	public void KillEnemy(GameObject enemy)
	{
		Swamp.Remove(enemy);	
	}
}