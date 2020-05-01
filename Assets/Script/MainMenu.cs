using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1f;

    public void NewGame()
    {
        FadeToNextScene();
    }

    public void FadeToNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int SceneIndex)
    {
        transition.SetTrigger("Start"); //Play animation

        yield return new WaitForSeconds(transitionTime); //Wait until animation ended

        SceneManager.LoadScene(SceneIndex); //Load next scene
    }

    public void Quit()
    {
        //Debug.Log("Game Quit");
        Application.Quit();
    }
}
