using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject uiElement;
    public GameObject uiElement2;
    public string nextLevel;
    public bool hasBodyParts;
    public GameObject[] bodyParts;

    private void Update()
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
            SceneManager.LoadScene(nextLevel);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiElement.SetActive(false);
        uiElement2.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        uiElement.SetActive(true);
        uiElement2.SetActive(true);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact"))
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        uiElement.SetActive(false);
        uiElement2.SetActive(false);
    }
}
