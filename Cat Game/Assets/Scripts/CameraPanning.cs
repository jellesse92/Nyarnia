using UnityEngine;
using System.Collections;

public class CameraPanning : MonoBehaviour {

    public void moveLeft()
    {
        if (Camera.main.transform.position.x >= -32)
        Camera.main.transform.Translate(-4, 0, 0);
    }

    public void moveRight()
    {
        if (Camera.main.transform.position.x <= 1)
        {
            Camera.main.transform.Translate(2, 0, 0);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    /*
	void Update () {
	if (Input.GetMouseButtonDown (0)) 
		{
			Camera.main.transform.Translate (-1,0,0);
		}

	}
    */



}
