using UnityEngine;
using System.Collections;

public class Npcs : BaseEnemy{
	private bool isRight;
	private float currentTimeChange;
	public float timeChange;
	private Player player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(Player)) as Player;
			isRight = false;
			base.Start ();



	}
	
	// Update is called once per frame
	void Update () {
		// para mov apenas em game if (gameController.CurrentState == StateMachine.INGAME) {
			
			Moviment ();
			
		//}
	}

	private void Moviment(){
		currentTimeChange += Time.deltaTime;
		
		if (currentTimeChange > timeChange) {
			
			if (isRight == false) {
				
				transform.eulerAngles = new Vector2 (0, 180);
				isRight = true;
			} else {
				transform.eulerAngles = new Vector2 (0, 0);
				isRight = false;
			}
			currentTimeChange = 1;
		}
		
		
		transform.Translate (-speed * Time.deltaTime, 0, 0);
		
		
	}

	void OnCollisionEnter2D(Collision2D other){
		
		if(other.gameObject.tag  == "Player"){
			
			

			player.life--;
		}
		
		
	}
}
