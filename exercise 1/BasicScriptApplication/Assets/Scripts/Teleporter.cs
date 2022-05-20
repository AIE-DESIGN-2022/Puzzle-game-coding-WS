using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Teleporter : MonoBehaviour
{

	public GameObject teleportOutLocation;
	public float red;
	public float green;
	public float blue;
	Color colorofteleporter;
	// Use this for initialization
	void Start()
	{
		colorofteleporter = new Color(red, green, blue);
		//Check if Teleport out location has been set.
		if (teleportOutLocation == null)
		{
			Debug.LogWarning("No Teleporter Out Location has been set for " + transform.name + ", Please set it and restart");
		}

		//Checks to see if you have set the collider on this object to a trigger 
		if (!GetComponent<Collider>().isTrigger)
		{
			Debug.LogWarning("Collider on " + transform.name + " is not set to \"Is Trigger\", please update and restart");
		}
	}

	// This function is called then any collider touches the collider on this object.
	void OnTriggerEnter(Collider collidedObject)
	{
		Debug.Log("Player Teleported");
		//Teleport GameObject that was collided with to the teleportOutLocation
		if (collidedObject.gameObject.tag == "Player" || collidedObject.gameObject.tag == "Box")
		{
			if(collidedObject.GetComponent<Renderer>().material.color == new Color(red,green,blue))
			{
				collidedObject.transform.position = teleportOutLocation.transform.position;

			}
		}

		//This section Draws a line from the teleporter in to the teleporter out within the editor
		void OnDrawGizmos()
		{
			Gizmos.DrawLine(transform.position, teleportOutLocation.transform.position);
		}
	}
}