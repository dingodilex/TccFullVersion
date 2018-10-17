using UnityEngine;
using System.Collections;

public class Caveman : BaseEnemy {
	private bool isRight;
	private float currentTimeChange;
	public float timeChange;
	// Use this for initialization
	void Start () {
		isRight = false;
		base.Start ();

	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.CurrentState == StateMachine.INGAME) {
			
			Moviment ();

		}
	}

	private void Moviment(){
		currentTimeChange += Time.deltaTime;

		if (currentTimeChange >= timeChange) {
			
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
}
