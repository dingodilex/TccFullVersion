using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void IniciaFloresta(){


		Application.LoadLevel("Forest");
	}

	public void IniciaTutorial(){
		
		
		Application.LoadLevel("Tutorial");
	}

	public void IniciaVolcano(){
		
		
		Application.LoadLevel("Volcano");
	}
}
