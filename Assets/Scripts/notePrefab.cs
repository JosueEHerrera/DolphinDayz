using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class notePrefab : MonoBehaviour 
{
	public float flyDistance;
	public float flySpeed;

	// Use this for initialization

	void OnEnable() 
	{
		StartCoroutine("makeNote");
		Debug.Log ("fuuuk");

	}
	void OnDisable()
	{
		StopAllCoroutines ();

	}

	IEnumerator makeNote()
	{

		float travelledDistance = 0;

		while (travelledDistance < flyDistance) 
		{
			travelledDistance += flySpeed * Time.deltaTime;
			transform.position += transform.up * (flySpeed * Time.deltaTime);
			yield return 0;
		}
		Destroy (gameObject);
	}
}
