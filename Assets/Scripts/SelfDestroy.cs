using System.Collections;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
	public float Delay;

	void Start()
	{
		StartCoroutine(DestroyCoroutine());
	}

	private IEnumerator DestroyCoroutine()
	{
		yield return new WaitForSeconds(Delay);
		Destroy(gameObject);
	}
}
