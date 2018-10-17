using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControll : MonoBehaviour {
	public float tim;
	public int cont;
	private Player player;
	private GameController gamecontroller;
	// Use this for initialization
	void Start () {
		gamecontroller = FindObjectOfType (typeof(GameController)) as GameController;
		if (tim < 10) {
			cont = 1;
		} else {
			cont = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		tim -= Time.deltaTime;

		/*if (tim >= 12 && tim <= 13) {

			Debug.Log(GameController.contCoin.ToString());
		}
	
*/
	
		if(tim <= 0)
		{
			if(cont == 0){
			Application.LoadLevel("Main");
			}else{
			Application.LoadLevel("Review");
			}
		}
	}

	public void FaseGO(){
		GameController.contCoin=+GameController.contCoin+100;
		Application.LoadLevel("Main");

	}
}
