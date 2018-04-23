using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
	public Camera Camera;
    public GameObject SpiritsControllerObject;
	public float Speed;
	
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
		SceneManager.LoadScene("FailScene");
	}

	void GameWon()
	{
		LevelFinished();
		SceneManager.LoadScene("Success");	
	}
}
