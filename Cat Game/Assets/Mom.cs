using UnityEngine;
using System.Collections;

public class Mom : MonoBehaviour {

    GameState gameState;
    // Use this for initialization
    void Start ()
    {
        gameState = GameObject.Find("GameManager").GetComponent<GameState>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if(gameState.inPlay == false) { gameObject.GetComponent<SpriteRenderer>().enabled = true; }
	}
}
