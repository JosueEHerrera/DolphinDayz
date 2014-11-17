using UnityEngine;
using System.Collections;

public class NoteGenerator : MonoBehaviour
{

	public Transform notePrefab;
	public float generationAngle;
	// Use this for initialization
	void Start () 
	{
		generationAngle = Random.Range(30.0f, 150.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray clickPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitPoint;
		
		// See if the ray collided with an object
		if (Physics.Raycast (clickPoint, out hitPoint)) 
		{
		 	if (Input.GetMouseButtonDown (0))
				{
					Vector3 position = new Vector3 (-2.311409f, 1.43019f, 0f);
					Quaternion noIdea = Quaternion.FromToRotation (position, transform.position);
					Instantiate (notePrefab, position, noIdea);
				}
		}
	
	}
}
