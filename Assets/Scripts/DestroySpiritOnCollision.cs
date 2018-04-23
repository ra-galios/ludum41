using UnityEngine;

public class DestroySpiritOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
		GameObject otherObj = other.gameObject;
		if(otherObj.CompareTag("Spirit"))
			Destroy(otherObj);
			
        throw new System.NotImplementedException();
    }
}
