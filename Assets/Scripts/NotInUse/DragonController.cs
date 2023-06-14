using UnityEngine;

public class DragonController : MonoBehaviour
{
    private Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    private int Speed = 2;

    private void Start()
    {
        player = GameObject.Find("Skull").transform;
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.LookAt(player);
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
    }
    
    private void FixedUpdate()
    {
       // MoveChar(movement);
    }

    private void MoveChar(Vector3 direction)
    {
      //  rb.MovePosition((Vector3)transform.position + (direction * Speed * Time.deltaTime));
    }
}
