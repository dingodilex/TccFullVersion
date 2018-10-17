using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	private Player player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType(typeof(Player)) as Player;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){

		if(other.gameObject.tag  == "Player"){


			Destroy(gameObject);
			player.life--;
		}


	}
}
