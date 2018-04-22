using UnityEngine;

public class SceneController : MonoBehaviour
{
	public Camera Camera;
    public GameObject SpiritsControllerObject;
	public float Speed;

	// Use this for initialization
	void Start ()
	{
		// ReSharper disable once HeapView.BoxingAllocation
		SpiritsControllerObject.SendMessage("SetSpeed", Speed);
		// ReSharper disable once HeapView.BoxingAllocation
		Camera.SendMessage("SetSpeed", Speed);
	}
}
