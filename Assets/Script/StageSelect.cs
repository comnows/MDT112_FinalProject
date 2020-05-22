using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1f;

    public void Stage1()
    {
        FadeToStage1();
    }

    public void FadeToStage1()
    {
        StartCoroutine(LoadStage(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Stage2()
    {
        FadeToStage2();
    }

    public void FadeToStage2()
    {
        StartCoroutine(LoadStage(SceneManager.GetActiveScene().buildIndex + 2));
    }

    public void Stage3()
    {
        FadeToStage3();
    }

    public void FadeToStage3()
    {
        StartCoroutine(LoadStage(SceneManager.GetActiveScene().buildIndex + 3));
    }

    IEnumerator LoadStage(int SceneIndex)
    {
        transition.SetTrigger("Start"); //Play animation

        yield return new WaitForSeconds(transitionTime); //Wait until animation ended

        SceneManager.LoadScene(SceneIndex); //Load next scene
    }

}
