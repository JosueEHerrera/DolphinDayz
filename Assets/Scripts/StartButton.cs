using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        Ray clickPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitPoint;
		
		// See if the ray collided with an object
	    if (Physics.Raycast(clickPoint, out hitPoint))
	    {
	        Application.LoadLevel(1);
	    }
	}
}
