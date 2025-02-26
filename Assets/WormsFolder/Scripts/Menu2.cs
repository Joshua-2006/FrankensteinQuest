using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu2 : MonoBehaviour
{
    public string nextLevel;
    public string otherLevel;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            Debug.Log("start has been pressed");
            SceneManager.LoadScene(nextLevel);

        }

        if (Input.GetButtonDown("Interact"))
        {
            Debug.Log("Interact has been pressed");
            SceneManager.LoadScene(otherLevel);
        }

        if (Input.GetButtonDown("Quit"))
        {
            Application.Quit();
            Debug.Log("It worked!");
        }
    }
}
