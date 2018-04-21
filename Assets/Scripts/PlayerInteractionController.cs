using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    public GameObject Wind;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos = Camera.main.ScreenToWorldPoint(pos);
            pos.z = 0;
            Instantiate(Wind, pos, Quaternion.identity);
        }
    }
}
