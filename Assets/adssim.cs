using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adssim : MonoBehaviour {
	public GameObject painel;
	public float tim = 200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tim -= Time.deltaTime;


		if (tim < 180 && tim >170) {
			painel.SetActive(true);
		}
		if (tim < 170) {
			painel.SetActive(false);

		}

		if (tim < 100 && tim >90) {
			painel.SetActive(true);
		}
		if (tim < 90) {
			painel.SetActive(false);
			
		}
	}
}
