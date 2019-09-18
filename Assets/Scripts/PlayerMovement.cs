using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 1000f;
    public enum Direction {North, South, East, West, None };

    public Direction xDirection = Direction.None;
    public Direction zDirection = Direction.None;

    void SetVelocity(Rigidbody rbody, Direction xDirection, Direction zDirection)
    {
        int xMove = 0;
        if (xDirection == Direction.East)
        {
            xMove = 1;
        }
        else if (xDirection == Direction.West)
        {
            xMove = -1;
        }

        int zMove = 0;
        if (zDirection == Direction.North)
        {
            zMove = 1;
        }
        else if (zDirection == Direction.South)
        {
            zMove = -1;
        }
        float realSpeed = speed * Time.deltaTime;

        rb.velocity = new Vector3(realSpeed * xMove, rb.velocity.y, realSpeed * zMove);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Get input for forward and back
        if (Input.GetKey("w"))
        {
            zDirection = Direction.North;
        }
        else if (Input.GetKey("s"))
        {
            zDirection = Direction.South;
        }
        else
        {
            zDirection = Direction.None;
        }

        //Get input for left and right
        if (Input.GetKey("d"))
        {
            xDirection = Direction.East;
        }
        else if (Input.GetKey("a"))
        {
            xDirection = Direction.West;
        }
        else
        {
            xDirection = Direction.None;
        }

        //Set velocity
        SetVelocity(rb, xDirection, zDirection);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
