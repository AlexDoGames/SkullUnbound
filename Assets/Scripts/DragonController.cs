using UnityEngine;

public class DragonController : MonoBehaviour
{
    public Transform Player;
    private Rigidbody rb;
    private Vector3 movement;
    public int Speed;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.LookAt(Player);
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
    }
    
    private void FixedUpdate()
    {
        MoveChar(movement);
    }
    private void MoveChar(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * Speed * Time.deltaTime));
    }
}
