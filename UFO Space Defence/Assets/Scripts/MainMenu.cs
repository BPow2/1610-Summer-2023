/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int sceneToLoad; // varible for deciding which scene to load

    public new AudioSource audio;

    public void playButton()
    {
        audio.Play();
    }

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
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad; // variable for deciding which scene to load
    public AudioSource audio;

    public void playButton()
    {
        audio.Play();
        Invoke("StartGameWithDelay", audio.clip.length);
    }

    public void quitButton()
    {
        audio.Play();
        Invoke("QuitGameWithDelay", audio.clip.length);
    }

    private void StartGameWithDelay()
    {
        SceneManager.LoadScene(sceneToLoad); // pick the scene to load
        Debug.Log("New Scene Loaded");
    }

    public void QuitGameWithDelay()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}