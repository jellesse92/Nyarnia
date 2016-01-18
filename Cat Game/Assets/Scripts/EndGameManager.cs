using UnityEngine;
using System.Collections;

public class EndGameManager : MonoBehaviour {
	public GameObject manager;
	public GameState gameState;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find ("GameManager");
		gameState = manager.GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayAgain()
	{
		gameState.movedRight = false;
		gameState.inPlay = true;
		gameState.timeLeft = gameState.TempNUM;
		gameState.LoadGameLevel ();
	}
}
