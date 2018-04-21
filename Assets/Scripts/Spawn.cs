using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject Spirit;
	public int Amount;
	public float Radius;
	
	// Use this for initialization
	void Start ()
	{
		Vector3 position = transform.position;
		
		for (int i = 0; i < Amount; i++)
		{
			Vector3 pos = new Vector3(position.x + Random.Range(-Radius, Radius), 
				position.y + Random.Range(-Radius, Radius), 0);
			Instantiate(Spirit, pos, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
