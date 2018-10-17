using UnityEngine;
using System.Collections;

public class Enemyai : BaseEnemy{
	private GameObject player;
	public bool isPlayer;
	public bool jump;
	private Rigidbody2D rgb2;
	public Transform i;
	public Transform f;
	// Use this for initialization
	void Start () {
		rgb2 = GetComponent<Rigidbody2D> ();
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		LookPlayer();
		Moviment ();
		RayCasting ();
		Jump ();
	}
	private void LookPlayer(){

		if (Vector2.Distance (player.transform.position, transform.position) < 3.5f) {
			isPlayer = true;

		} else {

			isPlayer = false;
		}

	}

	private void Moviment(){

		if(isPlayer) {
			if(transform.position.x < player.transform.position.x){
				rgb2.velocity = new Vector3(speed,0,0);
				transform.localScale = new Vector3(1,1,1);

			}else if(transform.position.x > player.transform.position.x){
				rgb2.velocity = new Vector3(-speed,0,0);
				transform.localScale = new Vector3(-1,1,1);

			}
		}

	}

	private void RayCasting(){

		if (Physics2D.Linecast (i.position, f.position)) {
			jump = true;


		} else {
			jump = false;
		}

	}

	private void Jump(){
		if (jump) {
		
			rgb2.AddForce(new Vector2(0,600));
		
		}

	}
}
