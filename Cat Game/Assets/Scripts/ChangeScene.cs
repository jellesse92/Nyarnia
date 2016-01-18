using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
    //public string s;
    GameState gameState;
    void Start()
    {
        gameState = GameObject.Find("GameManager").GetComponent<GameState>();
    }
	void Awake(){
		
	}
	// Use this for initialization
	public void ChangeToScene(string s){
        gameState.inPlay = true;
        gameState.reset();
		Application.LoadLevel (s);
	}
}
