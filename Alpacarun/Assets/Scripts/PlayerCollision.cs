using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;
    private bool death = false;



    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            death = true;
            

            rb.AddRelativeForce(transform.forward * -6000);
            FindObjectOfType<Geluidmanager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}