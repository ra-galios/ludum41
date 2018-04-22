using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class RotatingBlade : MonoBehaviour
{
	public float RotationSpeed;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().angularVelocity = RotationSpeed;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		GameObject otherObj = other.gameObject;
		if(otherObj.CompareTag("Spirit"))
			Destroy(otherObj);
	}
}
