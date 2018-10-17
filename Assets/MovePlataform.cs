using UnityEngine;
using System.Collections;

public class MovePlataform : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moviment ();
	}
	void moviment(){

		transform.Translate (0, speed*Time.deltaTime, 0);
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "limite")
			Debug.Log ("achou");
		    speed*=-1;

	}
}
