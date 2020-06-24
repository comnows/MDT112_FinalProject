using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHitSceneChange : MonoBehaviour
{
    public GameObject EnemyObject;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.Equals(EnemyObject))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("RabbitBattle");
        }
    }
}
