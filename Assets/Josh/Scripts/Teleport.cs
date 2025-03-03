using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleport;
    public GameObject player;
    public GameObject uiElement;
    public GameObject uiElement2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        uiElement.SetActive(true);
        uiElement2.SetActive(true);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButton("Interact"))
        {
            player.transform.position = teleport.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiElement.SetActive(false);
        uiElement2.SetActive(false);
    }
}
