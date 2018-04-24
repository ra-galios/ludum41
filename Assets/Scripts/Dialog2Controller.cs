using System;
using System.Collections.Generic;
using DefaultNamespace;
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
	public GameObject sad;

	private int _replique = 1;
	
	// Use this for initialization
	void Start ()
	{
		sad.GetComponent<Image>().sprite = Data.sad();
		RepliqueField.text = "Your fair guest is here again… You step towards the woman";
		Button1Text.text = "Your eyes are beautiful!";
		Button2Text.text = "May I ask, my lady, how you ended up here in this unholy place?";
	}

	public void Next()
	{
		
	}

	public void btn1click()
	{
		switch (_replique)
		{
			case 1:
				sad.GetComponent<Image>().sprite = Data.angry();
				btn2.SetActive(false);
				btn1.SetActive(false);
				RepliqueField.text = "Woman: You’re rude and shallow. Leave me alone!!";
				btn3.SetActive(true);
				break;
			case 2:
				btn2.SetActive(false);
				RepliqueField.text = "Woman: No more questions, Stranger. More souls are awaiting your help!";
				btn1.SetActive(false);
				btn3.SetActive(true);
				break;
		}
	}

	public void btn2Click()
	{
		sad.GetComponent<Image>().sprite = Data.happy();
		Data.NextGirl();
		_replique = 2;
		Button1Text.text = "Are you...";
		btn2.SetActive(false);
		RepliqueField.text =
			"Woman: You must know, Stranger, that the Death’s a guest who’s visit’s never wholly celebrated.";
	}

	public void btn3Click()
	{
		SceneManager.LoadScene("TestScene_halina_lastday_2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
