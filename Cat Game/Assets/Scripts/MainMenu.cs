using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public int Mode;
	// Use this for initialization
	void Start () {
		Mode = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		// Main Menu
		if (Mode == 0) {
			GUI.Box (new Rect (10, 10, 100, 30), "Main Menu");
			if(GUI.Button (new Rect (100,100,150,40), "New Game"))
			{
				Application.LoadLevel ("Main Game");
			}
			if(GUI.Button (new Rect (100,150,150,40), "Settings"))
			{
				Mode = 1;
			}
			if(GUI.Button (new Rect (100,200,150,40), "How To Play"))
			{
				Application.LoadLevel ("Tutorial");
			}
			if(GUI.Button (new Rect (100,250,150,40), "Credits"))
			{
				Mode = 3;
			}



		}

		// Settings Menu
		if (Mode == 1) {
			GUI.Box (new Rect (10, 10, 100, 30), "Settings");

			if(GUI.Button (new Rect (100,100,150,40), "Back to Main Menu"))
			{
				Mode=0;
			}

		}


		// Show Tutorial
		if (Mode == 2) {

		}

		// Show Credits
		if (Mode == 3) {
			GUI.Box (new Rect (10, 10, 100, 30), "Credits");
			
			if(GUI.Button (new Rect (100,100,150,40), "Back to Main Menu"))
			{
				Mode=0;
			}
		}

	}
}
