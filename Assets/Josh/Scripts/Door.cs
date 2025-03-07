using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Door : MonoBehaviour
{
    public GameObject uiElement;
    public GameObject uiElement2;
    public string nextLevel;
    
    public bool hasBodyParts;
    public int score;
    public int bodyParts;
    public TextMeshProUGUI bodyText;

    private void Start()
    {
        hasBodyParts = false;
    }
    private void Update()
    {
        bodyParts = FindObjectsOfType<Body>().Length;
        bodyPartCount();
        if (bodyParts == 0)
        {
            hasBodyParts = true;
        }
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
        if (collision.gameObject.CompareTag("Player") && Input.GetButton("Interact") && hasBodyParts)
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
    public void bodyPartCount()
    {
        bodyText.text = $": {score}";
    }
}
