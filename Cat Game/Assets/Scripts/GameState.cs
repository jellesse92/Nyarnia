using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameState : MonoBehaviour {
    public int num_of_cats;
    private int hidden_cats = 0;
	public float timeLeft;
	public int GameMode;
	public float TempNUM = 3;
	public bool inPlay;
    private int final_hidden = 0;
	public static GameState instance;
	public int RightBoundary;
	public int CamTIME = 5;
	public int LeftBoundary;
	public float transitionDuration = 5f;
	public AutoCam autoCam;
	public bool movedRight;

	// Use this for initialization
	public static GameState Instance
	{
		get
		{
            return instance;
		}
	}
	void Awake()
	{
		if (instance==null) {
			instance=this;
		} else if(instance!=this) {
			Destroy (gameObject);
		}DontDestroyOnLoad (gameObject);


		// GameMode 9 is Main Menu
		GameMode = 0;
		}
	void Start () {
        num_of_cats = 0;
		timeLeft = TempNUM;
        hidden_cats = 0;
        final_hidden = 0;
		inPlay = true;
		movedRight = false;
	}
	
	// Update is called once per frame
	void Update () {
        var cats = GameObject.FindGameObjectsWithTag("Cat");
        num_of_cats = cats.Length;
        hidden_cats = 0;
        for(int i = 0; i < num_of_cats; i++)
        {
            hidden_cats += (cats[i].GetComponent<Cat_Movement>().hidden == true ? 0 : 1);
        }

		if (timeLeft > 0 && GameMode == 0) {
			timeLeft -= Time.deltaTime;
		}
			if (timeLeft < 0) {
			inPlay = false;
            final_hidden = num_of_cats - hidden_cats;
			// Gamemode 3 is endgame checking mode 
			GameMode = 3;

			if (inPlay == false) {
				StartCoroutine ("CamPan");
			}


			// When the Camera has reached the end
			if (inPlay == false && Camera.main.transform.position.x < LeftBoundary) {
				autoCam.panning=false;
				movedRight=false;
				GameMode = 1;
				timeLeft = TempNUM;
				Application.LoadLevel ("EndGame");
			}
		}


	}

    void OnGUI()
    {
		// GameMode 0 is main gameplay screen
		if (GameMode == 0) {
			GUIStyle style = new GUIStyle (GUI.skin.GetStyle ("label"));
			style.fontSize = 30;
			GUI.color = Color.black;
			GUI.Label (new Rect (25, 25, Screen.width / 2, Screen.height / 2), "Total: " + num_of_cats, style);
			GUI.Label (new Rect (25, 60, Screen.width / 2, Screen.height / 2), "Visible: " + hidden_cats, style);
			GUI.Label (new Rect (25, 100, Screen.width / 2, Screen.height / 2), "Time: " + (int)timeLeft, style);
		}

		// GameMode 1 is Score screen 
		if (GameMode == 1) {
			GUIStyle style2 = new GUIStyle (GUI.skin.GetStyle ("label"));
			style2.fontSize = 40;
			GUI.color = Color.black;
			GUI.Label (new Rect (25, 25, Screen.width / 2, Screen.height / 2), "You have hidden : " + final_hidden + " cats!", style2);
		}
	}
	public void LoadGameLevel()
	{
		GameMode = 0;
		Application.LoadLevel ("MainScene");
	}

	public IEnumerator CamPan()
	{
		Vector3 newPosition = new Vector3(RightBoundary,0,-10);
		Vector3 leftPosition = new Vector3(LeftBoundary,0,-10);
		if (movedRight == false) {
			Camera.main.transform.position = newPosition;
		}
		movedRight = true;
		// This is the moment mom walks in to the room /////

		yield return new WaitForSeconds(1.0f);
		Vector3 minusVector = new Vector3 (.01f, 0, 0);
		if (movedRight) {
			autoCam.StartPanning ();
		}
		yield return new WaitForSeconds (4);

	}
}
