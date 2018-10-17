using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleShop : MonoBehaviour {
	public GameObject painel1;
	public GameObject painel2;
	public GameObject painel3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onPainel(){

		painel2.SetActive(false);
		painel3.SetActive(false);
		painel1.SetActive(true);
	}

	public void TwoPainel(){
		
		painel3.SetActive(false);
		painel1.SetActive(false);
		painel2.SetActive(true);
	}

	public void TreePainel(){

		painel1.SetActive(false);
		painel2.SetActive(false);
		painel3.SetActive(true);
		
	}


	public void GoBack(){

		Application.LoadLevel("Main");

	}
}
