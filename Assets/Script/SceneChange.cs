﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.name == "StoreDoor") //Change to name of gameObject
            {
                SceneManager.LoadScene("Home"); //Change to scene want to load
            }
            else if(other.gameObject.name == "BedroomDoor") //Change to name of gameObject
            {
                SceneManager.LoadScene("Bedroom"); //Change to scene want to load
            }
            else if(other.gameObject.name == "ExitStore") //Change to name of gameObject
            {
                SceneManager.LoadScene("LevelSelect"); //Change to scene want to load
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
                SceneManager.LoadScene("BossJungleBattle"); //Change to scene want to load
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
                SceneManager.LoadScene("BossIsland"); //Change to scene want to load
            }
            else if(other.gameObject.name == "PBR_Golem(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("GolemDesert"); //Change to scene want to load
            }
            else if(other.gameObject.name == "IguanaModel(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("IguanaDesert"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Tiger_idle(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("TigerDesert"); //Change to scene want to load
            }
            else if(other.gameObject.name == "Red(Clone)") //Change to name of gameObject
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("BossDesert"); //Change to scene want to load
            }

        }
}
