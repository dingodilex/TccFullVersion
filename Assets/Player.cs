using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float inputH;
	public float speed;
	public float jun;
	private Animator anim;
	private Rigidbody2D rgb2;
	public Transform Ground;
	public int life;
	private bool isvert;
	private bool isGround;
	private GameController gamecontroller;
	
	// Use this for initialization


	void Start () {
		life = 10;
		gamecontroller = FindObjectOfType (typeof(GameController)) as GameController;
		rgb2 = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gamecontroller.CurrentState == StateMachine.INGAME) {
			// #if !UNITY_ANDROID 
			//Moviment(Input.GetAxisRaw("Horizontal"));
//#else
			Moviment(inputH);
//#endif
			Jump (0);

		}
	}
	public void Moviment(float inpH){

		isGround = Physics2D.Linecast(transform.position,Ground.position,1<< LayerMask.NameToLayer("Ground"));
		isvert = Physics2D.Linecast(transform.position,Ground.position,1<< LayerMask.NameToLayer("Vert"));
		
		if (inpH < 0) {
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			
			
			anim.SetFloat ("Walk", Mathf.Abs(inpH*speed));
			transform.eulerAngles = new Vector2 (0, 180);
		} else if (inpH > 0) {
			transform.Translate(Vector2.right *speed*Time.deltaTime);
			anim.SetFloat ("Walk", Mathf.Abs(inpH*speed));
			transform.eulerAngles = new Vector2 (0, 0);
			
		}

		if (inpH == 0) {

			inputH =0;
			anim.SetFloat("Walk",0);
		}

			
		    
	

	    
	}

	public void Normalize(float inpH){

		inputH = inpH;
	}
	
	public void Jump(float start){
		/* #if !UNITY_ANDROID
		if (isGround != false && Input.GetKey (KeyCode.Space)) {

			anim.SetBool("Jump",!isGround);


			rgb2.AddForce (Vector2.up * 170);
		} else {
			anim.SetBool("Jump",!isGround);

		}
#else

		 #endif	*/

		if (isGround != false && start == 1) {
			
			anim.SetBool("Jump",!isGround);
			
			
			rgb2.AddForce (Vector2.up * jun);
		} else {
			anim.SetBool("Jump",!isGround);
			
		}



	
	}

	public void Splash(){


		if (isvert != false ) {
			
			anim.SetBool("Splash",!isvert);
		
			
			rgb2.AddForce (Vector2.left * 200);
		} else {
			anim.SetBool("Splash",!isvert);
			
		}

	}


}
