using UnityEngine;
using System.Collections;

public class GuiCounter : MonoBehaviour {

	public float dolphins =0;
	
	public GUIStyle style;
	
	private bool isPlaying;

	void OnEnable()
	{
		DolphinMovie.Splash += UpdateMaCounta;

		}
	void OnDisable()
	{
		DolphinMovie.Splash -= UpdateMaCounta;
		}

	// Use this for initialization
	void Start () {
		isPlaying = true;
		dolphins = 0;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateMaCounta()
	{
		dolphins++;
	}

	void OnGUI()
	{
		if (isPlaying)
		{
			GUI.Box(new Rect(20, 20, 300, 300), "" +dolphins, style);
		}
	}
}
