using UnityEngine;

public class BackgroundController : MonoBehaviour 
{	
	void OnTriggerEnter2D(Collider2D other)
	{
		GameObject otherGameObject = other.gameObject;
		if (gameObject.CompareTag("Camera"))
		{
			//Camera.
		}
	}
}
