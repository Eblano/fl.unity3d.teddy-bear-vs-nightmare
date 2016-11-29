using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwampScript : MonoBehaviour {
	
	public Transform EnemyPrefab;
	public Vector3 SpawnPoint = new Vector3(-27.8f,1.75f,6.5f);
	public bool isActive;
	
	float speed = 10;
	static List<GameObject> Enemies = new List<GameObject>();
	
	string PathUp ="Jump";
	string PathLeft = "Left";
	string PathRight = "Right";
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isActive){
			if(Enemies.Count==0){
				
				GameObject enemyUp = (Instantiate(EnemyPrefab,SpawnPoint,Quaternion.identity) as Transform).gameObject;
				GameObject enemyLeft = (Instantiate(EnemyPrefab,SpawnPoint,Quaternion.identity) as Transform).gameObject;
				GameObject enemyRight = (Instantiate(EnemyPrefab,SpawnPoint,Quaternion.identity) as Transform).gameObject;
				
				Enemies.Add(enemyUp);
				Enemies.Add(enemyLeft);
				Enemies.Add(enemyRight);
				
				iTween.MoveTo(enemyUp,iTween.Hash("path",iTweenPath.GetPath(PathUp),"speed",speed,"easetype","linear","oncomplete","PathCompleted","oncompleteparams",enemyUp,"orienttopath",true));
				iTween.MoveTo(enemyLeft,iTween.Hash("path",iTweenPath.GetPath(PathLeft),"speed",speed,"easetype","linear","oncomplete","PathCompleted","oncompleteparams",enemyLeft,"orienttopath",true));
				iTween.MoveTo(enemyRight,iTween.Hash("path",iTweenPath.GetPath(PathRight),"speed",speed,"easetype","linear","oncomplete","PathCompleted","oncompleteparams",enemyRight,"orienttopath",true));
			}
		}
	}
	
	public void Activate(){
		isActive=true;
	}
	
	void PathCompleted(GameObject subject){
		//GameObject go = subject as GameObject;
		
		Enemies.Remove(subject);
		
		Destroy(subject);
		
		isActive=false;
	}
}
