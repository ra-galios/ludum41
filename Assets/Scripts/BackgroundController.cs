using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour 
{
	public float TileSizeY;
	public Camera camera;

	private Vector3 _startPosition;
	
	// Use this for initialization
	void Start ()
	{
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 cameraVelocity = camera.GetComponent<Rigidbody2D>().velocity;
		float newPosition = Mathf.Repeat(Time.time * cameraVelocity.y, TileSizeY);
		transform.position = _startPosition + Vector3.up * newPosition;
		_startPosition = transform.position;
	}
}
