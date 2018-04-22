using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public Camera Camera;
    public GameObject SpiritsControllerObject;
	public float Speed;
	public Text LooserMessage;
	public Text CongratulationsMessage;

	// Use this for initialization
	private void Start ()
	{
		// ReSharper disable once HeapView.BoxingAllocation
		SpiritsControllerObject.SendMessage("SetSpeed", Speed);
		// ReSharper disable once HeapView.BoxingAllocation
		Camera.SendMessage("SetSpeed", Speed);
	}

	private void LevelFinished()
	{
		Destroy(SpiritsControllerObject.gameObject);
		Camera.SendMessage("SetSpeed", 0f);
	}

	void GameLost()
	{
		LevelFinished();
	    LooserMessage.gameObject.SetActive(true);
	}

	void GameWon()
	{
		LevelFinished();
		CongratulationsMessage.gameObject.SetActive(true);
	}
}
