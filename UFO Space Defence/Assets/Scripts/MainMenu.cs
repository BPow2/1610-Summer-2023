using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int sceneToLoad; // varible for deciding which scene to load

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);//pick the scene to load
        Debug.Log("New Scene Loaded");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}