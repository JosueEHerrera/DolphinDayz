using UnityEngine;
using System.Collections;

public class textScript : MonoBehaviour 
{
	MeshRenderer mr;
	ClickerFunction cf;
	GUIText tm;

	// Use this for initialization
	void Start () 
	{
		mr = GetComponent < MeshRenderer>();
		cf = FindObjectOfType<ClickerFunction>();
		tm = GetComponent<GUIText> ();
	}

	void Awake()
	{
		if (mr) {
			mr.sortingLayerName = "Default";
			mr.sortingOrder = -1;
				}
	}
	// Update is called once per frame
	void Update () {
		OnGui ();
	}

	void OnGui()
	{
				GUI.Label (new Rect (50, 50, 150, 20), "" + cf.dolphinCounter);
				Debug.Log ("Drawing OnGui");

				GUI.Box (new Rect (10, 10, 100, 200), "Menu");
				GUI.Label (new Rect (10, 10, 150, 20), "" + cf.dolphinCounter);
		
				// Make a button.  
				// Be able to click that button.
				// If they click it return inventory screen.
		
				if (GUI.Button (new Rect (20, 50, 75, 20), "Inventory")) {
			
						Debug.Log ("Your inventory opens");
			
						GUI.Box (new Rect (150, 10, 300, 200), "Inventory");
				}
		}
	}
	