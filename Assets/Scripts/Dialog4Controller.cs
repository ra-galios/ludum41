using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialog4Controller : MonoBehaviour
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
		RepliqueField.text = "Woman: Happy the man whom victory enhances! ";
		Button1Text.text = "Next";
		btn2.SetActive(false);
	}

	public void Next()
	{
		
	}

	public void btn1click()
	{
		switch (_replique)
		{
			case 1:
				_replique = 2;
				Button1Text.text = "My loins are ablaze, little darling. Come here...";
				Button2Text.text = "Whatever it takes, I’m ready to furfill my destiny and help those who are desperate and lost…";
				btn2.SetActive(true);
				RepliqueField.text =
					"Woman: You’ve saved a lot of souls, but your path has just begun…";
				break;
			case 2:
				btn2.SetActive(false);
				RepliqueField.text = "Woman: You insulting dog!";
				btn1.SetActive(false);
				btn3.SetActive(true);
				break;
			case 3:
				_replique = 4;
				Data.NextGirl();
				sad.GetComponent<Image>().sprite = Data.happy();
				if (Data.CurrentLevel == 2)
				{
					RepliqueField.text =
						"Woman: But first... my arms are open wide. Allow me to give you my last favoring...";
					Button1Text.text = "Follow her...";
		
				}
				else
				{
					RepliqueField.text =
						"Till we meet again... if fate allows...";
					btn1.SetActive(false);
					btn3.SetActive(true);
				}
				break;
			case 4:
				btn1.SetActive(false);
				RepliqueField.text = "Congratulations!!! Youve completely finished the game!";
				break;
			case 5:
				SceneManager.LoadScene("GameStart");
				break;
		}
	}

	public void btn2Click()
	{
		_replique = 3;
		btn2.SetActive(false);
		btn1.SetActive(true);
		Button1Text.text = "next";
		RepliqueField.text = "Woman: I bid you farewell";
	}

	public void btn3Click()
	{
		_replique = 5;
		RepliqueField.text = "I see... Not so good with girls, hah?. Next time you'd better be gentler with her.";
		btn1.SetActive(true);
		Button1Text.text = "Give yourself another chance";
		btn3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
