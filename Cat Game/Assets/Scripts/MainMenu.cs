using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public int Mode;

	public Texture startImg;
	public Texture howtoImg;
	public Texture quitImg;
	public Texture settingImg;


	private GUIStyle myStyle = new GUIStyle();

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
			if(GUI.Button (new Rect (600,250,150,40),startImg, myStyle))
			{
				Application.LoadLevel ("MainScene");
			}
			if(GUI.Button (new Rect (600,300,150,40), settingImg, myStyle))
			{
				Mode = 1;
			}
			if(GUI.Button (new Rect (600,350,150,40), howtoImg, myStyle))
			{
				Application.LoadLevel ("Tutorial");
			}
			if(GUI.Button (new Rect (600,400,150,40), "Credits"))
			{
				Mode = 3;
			}
			
			if(GUI.Button (new Rect (600,450,150,40), quitImg, myStyle))
			{
				Application.Quit();
				Debug.Log ("Quit Game");
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
