using UnityEngine;
using System.Collections;

public class CanvasController : MonoBehaviour {
	private Canvas canvas;
	GameState gameState;
	// Use this for initialization
	void Start () {
		canvas = GetComponent<Canvas> ();
		gameState = GameObject.Find ("GameManager").GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState.inPlay == false) {
			canvas.enabled=false;
		} else {
			canvas.enabled=true;
		}

	}
}
