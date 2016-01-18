using UnityEngine;
using System.Collections;

public class AutoCam : MonoBehaviour {
	public int leftBoundary = -30;
	public bool panning;
	public GameState gameState;
	Vector3 tempVector = new Vector3(0.1f,0,0);

	// Use this for initialization
	void Start () {
	}
	void Wake(){
		panning = false;
	}
	
	// Update is called once per frame
	void Update () {{
			if (panning) {
				if (Camera.main.transform.position.x > leftBoundary) {
					Camera.main.transform.position -= tempVector;
				} else {
					panning = false;
				}
			}
		}
	}
	public void StartPanning()
	{
		panning = true;
	}
}
