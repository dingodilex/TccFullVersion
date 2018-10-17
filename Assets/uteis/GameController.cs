using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public enum StateMachine{
	STARTGAME,
	INGAME,
	PAUSED,
	GAMEOVER,
	WINS


}
public class GameController : MonoBehaviour {

	// Use this for initialization
	public Sprite[] Life;
	public Image imgLife;
	private StateMachine stateMachine;
	private Player player;
	public static int contCoin = 1;
	public Text textCount;

	void Start () {
		player = FindObjectOfType(typeof(Player)) as Player;
		stateMachine = StateMachine.STARTGAME;
	}
	
	// Update is called once per frame
	void Update () {
		currentStateMachine ();
	}

	private void currentStateMachine(){


		switch (stateMachine) {

		case StateMachine.STARTGAME:
		{
			StartGame();
		}break;

		case StateMachine.INGAME:
			Time.timeScale=1;
			CheckLifePlayer();
		{
			
		}break;

		case StateMachine.PAUSED:
			Time.timeScale=0;
		{
			
		}break;

		case StateMachine.GAMEOVER:
		{
			
		}break;

		case StateMachine.WINS:
		{
			
		}break;

		}

	}

	public StateMachine CurrentState{

		get{return stateMachine;}
		set{stateMachine = value;}
	}

	public void StartGame(){

		CurrentState = StateMachine.INGAME;

	}
	public void CheckLifePlayer(){

		if (player.life == 1) {
			imgLife.sprite = Life[0];
		} else if (player.life == 2) {
			imgLife.sprite = Life[1];
		} else if (player.life == 3) {
			imgLife.sprite = Life[2];

		}else if (player.life == 4) {
			imgLife.sprite = Life[3];
			
		}else if (player.life == 5) {
			imgLife.sprite = Life[4];
			
		}else if (player.life == 6) {
			imgLife.sprite = Life[5];
			
		}else if (player.life == 7) {
			imgLife.sprite = Life[6];
			
		}else if (player.life == 8) {
			imgLife.sprite = Life[7];
			
		}else if (player.life == 9) {
			imgLife.sprite = Life[8];
			
		}
		else if (player.life == 10) {
			imgLife.sprite = Life[9];
			
		}




		else {
			Application.LoadLevel("GameOver");
		}
	}

}
