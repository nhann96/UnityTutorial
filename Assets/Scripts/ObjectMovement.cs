using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5000f;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed * Time.deltaTime);
    }
}
