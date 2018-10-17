using UnityEngine;
using System.Collections;

public class EnemyDino : BaseEnemy{
	public float timeChange;
	public float timeShot;
	public Transform distance;
	public Transform distanceBegin;


	private float currentTimeChange;
	private bool isRight;
	private float currentTimeShot;
	private bool isPlayer;
	private Player player;
	// Use this for initialization
	void Start () {
		    player = FindObjectOfType(typeof(Player)) as Player;
			isRight = false;
			base.Start ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.CurrentState == StateMachine.INGAME) {
		
			Moviment ();
			RayCast();
		}
	}

	private void Moviment(){
		currentTimeChange += Time.deltaTime;
		currentTimeShot += Time.deltaTime;
		if (currentTimeChange >= timeChange) {

			if (isRight == false) {

				transform.eulerAngles = new Vector2 (0, 180);
				isRight = true;
			} else {
				transform.eulerAngles = new Vector2 (0, 0);
				isRight = false;
			}
			currentTimeChange = 0;
		}


			transform.Translate (-speed * Time.deltaTime, 0, 0);

		
	}

	private void RayCast(){


		Debug.DrawLine (distanceBegin.position, distance.position, Color.red);
		isPlayer = Physics2D.Linecast (distanceBegin.position, distance.position, 1 << LayerMask.NameToLayer ("Player"));

		if (isPlayer && currentTimeShot > timeShot) {


			Instantiate(prefabMagia,transform.position,transform.rotation);
			currentTimeShot = 0;
		}
	}
}
