using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject uiElement;
    public string nextLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            uiElement.SetActive(true);
            if(Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiElement.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uiElement.SetActive(true);
            if (Input.GetButtonDown("Interact"))
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        uiElement.SetActive(false);
    }
}
