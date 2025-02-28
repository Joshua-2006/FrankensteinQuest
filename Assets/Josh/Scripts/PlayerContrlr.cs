using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContrlr : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;
    public Rigidbody2D rb;
    public bool grounded;
    public float jumpForce;
    public int jumps = 5;
    public Door door;

    public GameObject deathBarrier;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //finding gameObjects 
        deathBarrier = GameObject.Find("DeathBarrier");
        spawnPoint = GameObject.Find("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            jumps -= 1;
            grounded = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if(grounded == false)
        {
            rb.gravityScale = 4; 
        }
    }
    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * speed * horizontal, ForceMode2D.Impulse);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            rb.gravityScale = 1;
            jumps = 1;
        }
        if(collision.gameObject.CompareTag("Reset"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //if player falls off the map make sure to teleport them back to the spawn point
        if(collision.gameObject.CompareTag("DeathBarrier"))
        {
            transform.position = spawnPoint.transform.position;
        }
    }
}
