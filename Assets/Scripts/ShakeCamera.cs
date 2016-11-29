using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour {
	
	public void Shake(string axis, float val, float time){
		iTween.ShakePosition(gameObject,iTween.Hash(axis,val,"time",time));
	}
}
