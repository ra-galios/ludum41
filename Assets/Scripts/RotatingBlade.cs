using UnityEngine;

public class RotatingBlade : DestroySpiritOnCollision
{
	public float RotationSpeed;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().angularVelocity = RotationSpeed;
	}
}
