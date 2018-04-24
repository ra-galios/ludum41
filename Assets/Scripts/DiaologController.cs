using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiaologController : MonoBehaviour
{
	public Text RepliqueField;
	public Text ButtonText;

	private int _replique = -1;

	public Sprite[] girl11;
	
	
	private string[][] _dialogs = new string[][]
	{
		new String[]{"Wandering this land obscure and lonely, you’ve met a mysterious woman", "Next"},
		new String[]{"Woman: I've been waiting for you for too long…", "Next"},
		new String[]{"Woman: For the Spirits that walk in the shadows you are the last hope", "Why do you even care about those lost souls?"},
		new String[]{"Woman: Because you never know who they were in their previous life… Or who they might become", "Start"}
	};
	
	// Use this for initialization
	void Start ()
	{
		Data.CurrentLevel = 0;
		Data.currGirl = -1;
		Data.allGirls = girl11;
		Data.NextGirl();
		Next();
	}

	public void Next()
	{
		_replique++;
		if (_dialogs.Length > _replique)
		{
			string[] texts = _dialogs[_replique];
			RepliqueField.text = texts[0];
			ButtonText.text = texts[1];
		}
		else
		{
			startGame();
		}
	}

	private void startGame()
	{
		SceneManager.LoadScene("TestScene_halina_lastday");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
