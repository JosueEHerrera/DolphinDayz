using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ClickerFunction : MonoBehaviour
{


	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	public GameObject[] gosToDisableOnStart;
	public GameObject[] gosToEnableOnClick;
	public int dolphinCounter;

	public GameObject dolphinPrefab;

	private SpriteRenderer spriteRenderer;
	private AudioSource soundSource;
	public AudioClip touchButtonClip;

	void Start()
	{
		dolphinCounter = 0;
		foreach(GameObject go in gosToDisableOnStart)
			go.SetActive(false);
	    spriteRenderer = GetComponent<SpriteRenderer> (); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
		spriteRenderer.sprite = sprite1; // set the sprite to sprite1
		AudioSource[] sources = FindObjectsOfType <AudioSource> ();
		foreach (AudioSource s in sources) {
    		if(s.gameObject.name.Contains("Keyboard"))
	    		soundSource = s;
		}
		if (soundSource == null) {
			if(sources.Length > 0)
			{
				if(sources[0] != null)
					soundSource = sources[0];
			}
		}

	}
	void Update()
	{
		if (Time.timeScale == 1) {
						Ray clickPoint = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit hitPoint;
		
						// See if the ray collided with an object
						if (Physics.Raycast (clickPoint, out hitPoint)) {
								if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Space)) {
										spriteRenderer.sprite = sprite2;
										if (soundSource != null) {
						if (touchButtonClip != null) {
							soundSource.clip = touchButtonClip;
							if(!soundSource.isPlaying)
								soundSource.Play();
														Debug.Log ("Successfully played sound!");


												}
										}
										foreach(GameObject go in gosToEnableOnClick)
					{
						go.SetActive(true);
						dolphinCounter++;
					}
					TryToLaunchNewDolphin();

								}
								if (Input.GetMouseButtonUp (0) || Input.GetKeyUp (KeyCode.Space)) {
										spriteRenderer.sprite = sprite1;

								}
						}
				} else {
				}
	}

	private void TryToLaunchNewDolphin()
	{
		if (dolphinPrefab != null) {
			Instantiate(dolphinPrefab, new Vector3(37.0f, Random.Range(-16.0f,20.0f), 0.0f), new Quaternion());
			dolphinCounter++;
				}
		}
}