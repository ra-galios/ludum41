using UnityEngine;
using UnityEngine.UI;

public class SpiritsController : MonoBehaviour
{
	public MonoBehaviour GameController;
	public GameObject Spirit;
	public int StartAmount;
	public float Radius;
	public Text LooseText; 

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
			spirit.SendMessage("Init", this);
			
		}
	}

	public void DecreaseSpiritsAmount()
	{
		_spiritsAlive--;

		if (_spiritsAlive < 1)
		{
			LooseText.gameObject.SetActive(true);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Spirit"))
		{
			Destroy(other.gameObject);
		}
	}
}
