using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialog2Controller : MonoBehaviour
{
	public Text RepliqueField;
	public Text Button1Text;
	public Text Button2Text;
	public GameObject btn2;
	public GameObject btn1;
	public GameObject btn3;
	public GameObject madam1;
	public GameObject madam2;

	private int _replique = 1;
	
	// Use this for initialization
	void Start ()
	{
		RepliqueField.text = "Your fair guest is here again… You step towards the woman";
		Button1Text.text = "Your eyes are beautiful!";
		Button2Text.text = "May I ask, my lady, how you ended up here in this unholy place?";
	}

	public void Next()
	{
		
	}

	public void btn1click()
	{
		btn2.SetActive(false);
		if (_replique == 1)
		{
			btn1.SetActive(false);
			RepliqueField.text = "Woman: You’re rude and shallow. Leave me alone!! \n to be continued...";
		}
		else if(_replique == 2)
		{
			RepliqueField.text = "Woman: No more questions, Stranger. More souls are awaiting your help \n to be contined...";
			btn1.SetActive(false);
		}
		
		btn3.SetActive(true);
		_replique++;
	}

	public void btn2Click()
	{
		madam1.SetActive(false);
		madam2.SetActive(true);
		btn1.SetActive(false);
		btn2.SetActive(false);
		RepliqueField.text =
			"Woman: You must know, Stranger, that the Death’s a guest who’s visit’s never wholly celebrated.";
		btn3.SetActive(true);
	}

	public void btn3Click()
	{
		SceneManager.LoadScene("GameStart");
	}

	private void startGame()
	{
		SceneManager.LoadScene("TestScene_halina_lastday");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
