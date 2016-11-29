using UnityEngine;
using System.Collections;

public class GUIPositions : MonoBehaviour {
	
	public float x;
	public float y;
	public float width;
	public float height;
	public bool isText = false;
	
	public float designWidth = 994;
	public float designHeight = 663;
	
	public bool Reset;
	
	void Awake(){
	//void Update(){		
		SetGUI ();
	}
	 
	void Update(){
	
		if(Reset){
			Reset = false;
			SetGUI ();
		}
		
	}
	
	void SetGUI(){
		if(!isText){
			Rect resized = ResizeGUI(new Rect(x,y,width,height));
			this.GetComponent<GUITexture>().pixelInset = resized;
		}else{
			Vector2 v = this.GetComponent<GUIText>().pixelOffset;
			v.x = (x / designWidth) * Screen.width;
			v.y = (y / designHeight) * Screen.height;
			this.GetComponent<GUIText>().pixelOffset = v;
		}	
	}
	
	Rect ResizeGUI(Rect _rect)
	{
	    float FilScreenWidth = _rect.width / designWidth;
	    float rectWidth = FilScreenWidth * Screen.width;
	    float FilScreenHeight = _rect.height / designHeight;
	    float rectHeight = FilScreenHeight * Screen.height;
	    float rectX = (_rect.x / designWidth) * Screen.width;
	    float rectY = (_rect.y / designHeight) * Screen.height;
	 
	    return new Rect(rectX,rectY,rectWidth,rectHeight);
	}
}
