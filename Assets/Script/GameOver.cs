using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1f;

    public void Mainmenu()
    {
        FadeToMainMenu();
    }

    public void FadeToMainMenu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    IEnumerator LoadScene(string SceneIndex)
    {
        transition.SetTrigger("Start"); //Play animation

        yield return new WaitForSeconds(transitionTime); //Wait until animation ended

        SceneManager.LoadScene(SceneIndex); //Load scene
    }

}
