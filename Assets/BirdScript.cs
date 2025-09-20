using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidbody;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocity = Vector2.up * 10;
    }
}
