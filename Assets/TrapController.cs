using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
	private GameObject child;
	public float Delay;
	
	// Use this for initialization
	void Start ()
	{
		child = transform.GetChild(0).gameObject;

		if (Delay < 0.1)
		{
			child.SetActive(true);
		}
		else
		{
			StartCoroutine(RunTrap());
		}
	}

	private void FlipVisibility()
	{
		child.SetActive(!child.activeSelf);	
	}

	IEnumerator RunTrap()
	{
		while (true)
		{
			FlipVisibility();
			yield return new WaitForSeconds(Delay);
		}
	}
	
}
