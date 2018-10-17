using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	private GameController gamecontroller;
	// Use this for initialization
	void Start () {
		gamecontroller = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		
        if (other.gameObject.tag == "Player") {
			Destroy (gameObject);	
			GameController.contCoin=+GameController.contCoin+1;
			gamecontroller.textCount.text = GameController.contCoin.ToString();

			// Debug.Log(GameController.contCoin);

		}
	}

}
