using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllads : MonoBehaviour {
	public float tim;
	public int cont;

	// Use this for initialization
	void Start () {

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
		Application.LoadLevel("Fasesc");

		}
	}

	public void FaseGO(){
          Application.LoadLevel("Main");

	}
}
