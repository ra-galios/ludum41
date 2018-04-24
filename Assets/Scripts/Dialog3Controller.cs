using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialog3Controller : MonoBehaviour
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
		RepliqueField.text = "The woman appears in front of you again";
		Button1Text.text = "My lady, why these Spirits are doomed to this torture?";
		Button2Text.text = "Mademoiselle, your posterior is magnificent!";
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
				sad.GetComponent<Image>().sprite = Data.happy();
				Button1Text.text = "Next";
				btn2.SetActive(false);
				RepliqueField.text =
					"Woman: You must know, Stranger, that the Death’s a guest who’s visit’s never wholly celebrated.";
				break;
			case 2:
				btn2.SetActive(false);
				RepliqueField.text = "Woman: I can only offer you the gratitude of the souls whose sorrows are unimaginable!";
				btn1.SetActive(false);
				btn3.SetActive(true);
				break;
		}
	}

	public void btn2Click()
	{
		sad.GetComponent<Image>().sprite = Data.angry();
		btn2.SetActive(false);
		btn1.SetActive(false);
		RepliqueField.text = "Woman: You are disgusting";
		btn3.SetActive(true);
	}

	public void btn3Click()
	{
		SceneManager.LoadScene("TestScene_halina_lastday_3");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
