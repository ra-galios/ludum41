using UnityEngine;

public class BackgroundController : MonoBehaviour 
{
	public float TileSizeY;
	public Camera Camera;

	private Vector3 _startPosition;
	
	// Use this for initialization
	void Start ()
	{
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		var cameraVelocity = Camera.GetComponent<Rigidbody2D>().velocity;
		var newPosition = Mathf.Repeat(Time.time * cameraVelocity.y, TileSizeY);
		transform.position = _startPosition + Vector3.up * newPosition;
		_startPosition = transform.position;
	}
}
