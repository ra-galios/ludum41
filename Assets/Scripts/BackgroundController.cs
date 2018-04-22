using UnityEngine;

public class BackgroundController : MonoBehaviour
{
	public GameObject SceneControllerObject;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		var otherGameObject = other.gameObject;
		if (otherGameObject.CompareTag("Spirit"))
		{
			SceneControllerObject.SendMessage("GameWon");
		}
	}
}
