using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiritsController : MonoBehaviour
{
	public GameObject SceneControllerObject;
	public GameObject Spirit;
	public int StartAmount;
	public float Radius;
	public Text SpiritsAmountText;
	
	private readonly List<GameObject> _spiritInstances = new List<GameObject>();
	private float _force;
	private int _spiritsAlive;
	
	// Use this for initialization
	void Start ()
	{
		_spiritsAlive = StartAmount;
		Vector3 position = transform.position;
		
		for (int i = 0; i < StartAmount; i++)
		{
			Vector3 pos = new Vector3(position.x + Random.Range(-Radius, Radius), 
				position.y + Random.Range(-Radius, Radius), 0);
			GameObject spirit = Instantiate(Spirit, pos, Quaternion.identity);
			_spiritInstances.Add(spirit);
			spirit.SendMessage("Init", this);
		}
		
		SetSpeed(_force);
		UpdateSpiritsUiCounter();
	}

	private void SetSpeed(float force)
	{
		_force = force;
		foreach (var spiritInstance in _spiritInstances)
		{
			spiritInstance.GetComponent<Rigidbody2D>().GetComponent<ConstantForce2D>().force = new Vector2(0, force);
		}
	}

	private void UpdateSpiritsUiCounter()
	{
		if(!SpiritsAmountText.IsDestroyed())
			SpiritsAmountText.text = _spiritsAlive.ToString() + " / " + StartAmount.ToString();
	}

	public void SpiritDestoyed(GameObject spirit)
	{
		if(_spiritInstances.Remove(spirit))
			DecreaseSpiritsAmount();
	}

	private void OnDestroy()
	{
		List<GameObject> spirits = new List<GameObject>(_spiritInstances);
		_spiritInstances.Clear();
		foreach (var spirit in spirits)
		{
			Destroy(spirit);
		}
	}

	private void DecreaseSpiritsAmount()
	{
		_spiritsAlive--;

		UpdateSpiritsUiCounter();
		if (_spiritsAlive < 1)
		{
			SceneControllerObject.SendMessage("GameLost");			
		}
	}
}
