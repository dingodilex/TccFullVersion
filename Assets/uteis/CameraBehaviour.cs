using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
	private Vector2 speed;
	private float smootf = 0.5f;
	private GameObject player;
	// Use this for initialization
	void Start () {
		
		player = GameObject.Find("Player");
		speed = new Vector2 (0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		Follow ();
	}
	
	private void Follow(){
		
		Vector2 positionCamera = Vector2.zero;
		
		positionCamera.x = Mathf.SmoothDamp (transform.position.x,player.transform.position.x, ref speed.x, smootf);
		positionCamera.y = Mathf.SmoothDamp (transform.position.y,player.transform.position.y, ref speed.y, smootf);
		
		Vector3 newPosition = new Vector3 (positionCamera.x, positionCamera.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, newPosition, Time.time);
	}
}