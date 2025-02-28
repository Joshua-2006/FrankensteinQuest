using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleport;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButton("Interact"))
        {
            player.transform.position = teleport.transform.position;
        }
    }
}
