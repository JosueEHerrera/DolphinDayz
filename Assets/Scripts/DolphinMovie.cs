using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DolphinMovie : MonoBehaviour {

	public delegate void DolphinPorno();
	public static event DolphinPorno Splash;

	public float speedModiferLow = 0.05f;
	public float speedModifierHigh = 0.50f;
	public float boundsModifer = 5.0f;
	private float topBounds;
	private float botBounds;
	private bool goingUp = true;
	private bool goingDown = false;

	void OnEnable()
	{
		if (Splash != null)
			Splash();
		}

	void Start()
	{
		topBounds = gameObject.transform.position.y + boundsModifer;
		botBounds = gameObject.transform.position.y - boundsModifer;
		}

	void Update () {
				if (gameObject.transform.position.x > -28) {
						Debug.Log ("MOVING");
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x - Random.Range (speedModiferLow, speedModifierHigh), gameObject.transform.position.y, gameObject.transform.position.z);
				} else
						gameObject.transform.position = new Vector3 (37.0f, gameObject.transform.position.y, gameObject.transform.position.z);
				if (goingUp) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + Random.Range (speedModiferLow, speedModifierHigh), gameObject.transform.position.z);
				} else if(goingDown){
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y - Random.Range (speedModiferLow, speedModifierHigh), gameObject.transform.position.z);

				}
				if (gameObject.transform.position.y > topBounds) {
						goingUp = false;
			goingDown = true;
				} if( gameObject.transform.position.y < botBounds){
						goingUp = true;
			goingDown = true;
				}
		}
}
