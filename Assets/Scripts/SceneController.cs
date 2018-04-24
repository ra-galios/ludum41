using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public Camera Camera;
    public GameObject SpiritsControllerObject;
	public GameObject RestartView;
	public float Speed;
	
	// Use this for initialization
	private void Start ()
	{
		Data.CurrentLevel = SceneManager.GetActiveScene().buildIndex;
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
		SceneManager.LoadScene("FailScene");
	}

	void GameWon()
	{
		LevelFinished();
		SceneManager.LoadScene("Success");	
	}
}
