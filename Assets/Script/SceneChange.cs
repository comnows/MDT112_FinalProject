using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.name == "StoreDoor") //Change to name of gameObject
            {
                SceneManager.LoadScene("MainMenu"); //Change to scene want to load
            }
            else if(other.gameObject.name == "BedroomDoor") //Change to name of gameObject
            {
                SceneManager.LoadScene("Bedroom"); //Change to scene want to load
            }
            else if(other.gameObject.name == "ExitStore") //Change to name of gameObject
            {
                SceneManager.LoadScene("LevelSelect"); //Change to scene want to load
            }
        }
}
