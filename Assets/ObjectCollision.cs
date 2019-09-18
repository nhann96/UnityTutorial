using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Skybox")
        {
            Destroy(gameObject);
            ScoreCounter.Instance.Score++;
        }
    }
}
