using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Wind;
    private float _cameraMaxSpeed;
    
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

    private void FixedUpdate()
    {
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        Vector2 currentVelocity = rigidbody2D.velocity;
        if (currentVelocity.y > _cameraMaxSpeed)
        {
            currentVelocity.y = _cameraMaxSpeed;
            rigidbody2D.velocity = currentVelocity;
        }
    }

    public void SetSpeed(float maxSpeed)
    {
        _cameraMaxSpeed = maxSpeed;
        Rigidbody2D localRigidbody2D = GetComponent<Rigidbody2D>();
        localRigidbody2D.GetComponent<ConstantForce2D>().force = new Vector2(0, maxSpeed);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spirit"))
        {
            Destroy(other.gameObject);
        }
    }
}
