using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrlr : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;
    public Rigidbody2D rb;
    public bool grounded;
    public float jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * speed * horizontal, ForceMode2D.Impulse);
        
        if(Input.GetKeyDown(KeyCode.W) && grounded)
        {
            grounded = false;
            rb.AddForce(Vector2.up * jumpForce * vertical, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
