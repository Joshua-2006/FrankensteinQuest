using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
    public void OnMenuButton(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}