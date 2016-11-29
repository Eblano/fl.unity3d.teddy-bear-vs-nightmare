using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthManagerScript : MonoBehaviour {
	
	public float textureWidth;
	public float textureHeight;
	public float startX;
	public float startY;
	public float spacing;
	
	public GameObject healthPrefab;
	
	public int MaxHealth;
	
    public int Health {
		get{return _health;}
	}
	
	private int _health;	
	private List<Transform> healthOnScreen;
	
	void Start(){
		Init (MaxHealth);	
	}
	
	public void Init(int maxHealth){
		_health = maxHealth;
		healthOnScreen = new List<Transform>();
		
		for(int i=0;i<maxHealth;i++){
			healthOnScreen.Add(CreateHealth(i));
		}
	}
	
	public void RemoveHealth(int amount){
		
		_health = _health-amount;
		if(_health<=0){
			Application.LoadLevel("GameOver");	
		}
		
		foreach(Transform t in healthOnScreen){
			if(amount==0){break;}
			
			HealthPointScript health = t.GetComponent<HealthPointScript>();
			if(health.isOn){
				health.ChangeState();	
				amount--;
			}
		}
	}
	
	Transform CreateHealth(int count){
		GameObject h = (GameObject)Instantiate(healthPrefab);
		h.transform.parent = this.transform;
		GUIPositions pos = h.GetComponent<GUIPositions>();
		
		if(count==0){
			pos.x = startX;
			pos.y = startY;
		}else{
			pos.x = ((textureWidth + spacing) * count) + startX;	
		}
		pos.Reset=true;
		
		return h.transform;
	}
}
