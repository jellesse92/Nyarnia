using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	//public string s;
	void Awake(){
		
	}
	// Use this for initialization
	public void ChangeToScene(string s){
		Application.LoadLevel (s);
	}
}
