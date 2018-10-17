using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerPause : MonoBehaviour {

	public GameObject painel;
	private bool isPaused;
	private GameController gameController;

	void Start (){
		 isPaused = false;
		gameController = FindObjectOfType(typeof(GameController)) as GameController;
	}

	public void Paused(){

		if (isPaused == false) {
			gameController.CurrentState = StateMachine.PAUSED;
			painel.SetActive(true);
			isPaused = true;
		}else{
			gameController.CurrentState =StateMachine.INGAME;
			painel.SetActive(false);
			isPaused = false;

		}

	}
	


}
