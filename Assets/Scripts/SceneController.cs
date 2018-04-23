using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
	public Camera Camera;
    public GameObject SpiritsControllerObject;
	public float Speed;
	public Text LooserMessage;
	public Text CongratulationsMessage;
	public String NextScene;
	public Scene Scene;
	
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
		nextScene();
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	
	private void nextScene()
	{
		if (!string.IsNullOrEmpty(NextScene))
		{
			SceneManager.LoadScene(NextScene);
		}
	}
}
