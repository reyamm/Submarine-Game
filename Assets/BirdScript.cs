using UnityEngine;

public class BirdScript : MonoBehaviour
{
public Rigidbody2D myRigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public float jumpForce = 7f;      // how strong the jump is
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   // get the Rigidbody2D from the object
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))   // when space is pressed
        {
            rb.linearVelocity = Vector2.up * jumpForce;  // make it fly upward
        }
    }
}