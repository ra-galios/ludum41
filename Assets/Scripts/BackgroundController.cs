using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour 
{
	public float scrollSpeed;
	public float TileSizeY;

	private Vector3 _startPosition;
	
	// Use this for initialization
	void Start ()
	{
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, TileSizeY);
		transform.position = _startPosition + Vector3.up * newPosition;
	}
}
