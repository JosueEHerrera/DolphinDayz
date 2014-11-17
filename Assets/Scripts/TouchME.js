var icon: Texture2D;

function OnGUI () {
    // Make a bacground box
    GUI.Box (Rect (Screen.width/2-50,Screen.height/2-45,100,90) , "Main Menu");

    // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
    if (GUI.Button (Rect (Screen.width/2-40,Screen.height/2-10,80,20) , "Lets Play")) {
        Application.LoadLevel (1);
    }

    // Make the second button.
    if (GUI.Button (Rect (Screen.width/2-40,Screen.height/2+10,80,20) , "Options")) {
        Application.LoadLevel (2);
    }
}

	
	
	
	
	