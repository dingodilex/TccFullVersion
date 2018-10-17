using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {
	public GameObject painel1;
	private GameController gameController;
	// Use this for initialization
	void Start () {
		gameController = FindObjectOfType(typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		
		if(other.gameObject.tag  == "Player"){
			
			painel1.SetActive(true);
			gameController.CurrentState = StateMachine.PAUSED;

		}
		
		
	}
}
