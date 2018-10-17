using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
	public Text texto;
	private GameController gamecontroller;
	// Use this for initialization
	void Start () {
		gamecontroller = FindObjectOfType (typeof(GameController)) as GameController;

	}
	
	// Update is called once per frame
	void Update () {
		texto.text = GameController.contCoin.ToString();
		//Debug.Log(GameController.contCoin.ToString());
	}

	public void Volcano(){

		Application.LoadLevel("Volcano");

	}

	public void Forest(){
		
		Application.LoadLevel("Forest");
		
	}

	public void Forestlow(){
		
		Application.LoadLevel("Forestlow");
		
	}


	public void Desert(){
		
		Application.LoadLevel("Desert");
		
	}
	
	public void Beach(){
		
		Application.LoadLevel("Beach");
		
	}

	public void Winter(){

		Application.LoadLevel("Winter");
	}

	public void GoBack(){
		
		Application.LoadLevel("Main");
	}

	public void GoF(){
		
		Application.LoadLevel("Fasesc");
	}

	public void GoPubli(){
		
		Application.LoadLevel("Publicidade1");
	}

	public void GoShop(){
		
		Application.LoadLevel("Shop");
	}

	public void GoPubli3(){
		
		Application.LoadLevel("Publicidade3");
	}
}
