using UnityEngine;
using System.Collections;

public class ExitScene : MonoBehaviour {

	// Use this for initialization
	private GameObject player;
	private Vector3 positionStart;
	private Player players;
	void Start () {
	
		player = GameObject.FindWithTag ("Player");
		positionStart = player.transform.position;
		players = FindObjectOfType(typeof(Player)) as Player;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D(Collider2D other){


		if (other.gameObject.tag == "Player") {
			players.life--;
			player.transform.position = positionStart;

		}

	}
}
