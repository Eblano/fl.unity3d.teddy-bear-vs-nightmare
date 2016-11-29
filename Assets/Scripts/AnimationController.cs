using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
	
	private CharacterController character;
	private Animation thisAnimation;
	private Collider thisCollider;
	
	private static string ANIM_CORSA = "corsa";
	private static string ANIM_CAMMINA = "cammina";
	private static string ANIM_RESPIRO = "respiro";
	private static string ANIM_COLPITO = "colpito";
	private static string ANIM_ATTACCO2 = "attacco2";
	private static string ANIM_LANCIO = "lancioEvent";
	
	private bool WaitTillEnd = false;
	
	public float runningSpeed = 1.5f;
	
	// Use this for initialization
	void Start () {
		character = GetComponent<CharacterController>();
		thisAnimation = GameObject.Find("Orsetto").GetComponent<Animation>();
		thisAnimation.wrapMode = WrapMode.Loop;
		thisAnimation[ANIM_COLPITO].wrapMode = WrapMode.ClampForever;
		thisAnimation[ANIM_ATTACCO2].wrapMode = WrapMode.Once;
		thisAnimation[ANIM_LANCIO].wrapMode = WrapMode.Once;
		thisCollider = character.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 horizontalVelocity = character.velocity;
		horizontalVelocity.y = 0; // ignore any vertical movement
		float speed = horizontalVelocity.magnitude;
		
		if(thisAnimation.IsPlaying(ANIM_COLPITO) == false && WaitTillEnd == false){
			if(speed > 0)
			{
				if(speed > runningSpeed){
					thisAnimation.CrossFade(ANIM_CORSA);	
				}else if(speed > 0 && speed <= runningSpeed){
					thisAnimation.CrossFade(ANIM_CAMMINA);
				}
			}
			else{
				thisAnimation.CrossFade(ANIM_RESPIRO);
			}
		}
		else
		{
			if(thisAnimation.IsPlaying(ANIM_ATTACCO2)== false && thisAnimation.IsPlaying(ANIM_LANCIO) == false){
				WaitTillEnd = false;
				thisAnimation.CrossFade(ANIM_RESPIRO);
			}
		}
	}
	
	public void PlayAttacco2 ()
	{
		thisAnimation.CrossFade(ANIM_ATTACCO2);	
		WaitTillEnd = true;
	}
	
	public void PlayLancio ()
	{
		thisAnimation.CrossFade(ANIM_LANCIO);	
		WaitTillEnd = true;
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.gameObject.tag == "Wall"){
			thisAnimation.Play(ANIM_COLPITO);
			//character.SimpleMove(Vector3.back * 2);
		}
	}
}
