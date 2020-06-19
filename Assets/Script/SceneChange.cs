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
                SceneManager.LoadScene("story2"); //Change to scene want to load
            }
            else if(other.gameObject.name == "ExitStore") //Change to name of gameObject
            {
                SceneManager.LoadScene("story3"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Rabbit 1(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("RabbitBattle"); //Change to scene want to load
            }
            else if(other.gameObject.name == "spider(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("SpiderBattle"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Rhino(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("RhinoBattle"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Green(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("story4"); //Change to scene want to load
            }
            else if(other.gameObject.name == "bdl_byx(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("CrabIsland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "ToxicFrog(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("FrogIsland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Golem(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("HuclamIsland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Purple(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("story8"); //Change to scene want to load
            }
            else if(other.gameObject.name == "PBR_Golem(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("GolemDesert"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Iguana(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("IguanaDesertland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "tiger_idle(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("TigerDesertland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Red(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("story6"); //Change to scene want to load
            }

        }
}
