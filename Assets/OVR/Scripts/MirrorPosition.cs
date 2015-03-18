using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour {
	
	public GameObject mirrorObject; // Object to mirror
	public bool mirrorX; // Wether or not to mirror the X axis
	public bool mirrorY; // Wether or not to mirror the Y axis
	public bool mirrorZ; // Wether or not to mirror the Z axis
	public bool useLateUpdate; // Wether or not to set the object's position in LateUpdate
	void Update()
	{
		Vector3 newPosition;
		newPosition = mirrorObject.transform.position; // Get the mirrorObject's position
		if(mirrorX)
		{
			newPosition.x = -newPosition.x; // Mirror on the X axis
		}
		if(mirrorY)
		{
			newPosition.y = -newPosition.y; // Mirror on the Y axis
		}
		if(mirrorZ)
		{
			newPosition.y = -newPosition.y; // Mirror on the Z axis
		}
		if(!useLateUpdate)
			transform.position = newPosition; // Set object's position equal to the new mirrored position
	}
//	void LateUpdate()
//	{
//		if(useLateUpdate)
//			transform.position = newPosition; // Set object's position equal to the new mirrored position
//	}
}