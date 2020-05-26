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
            SceneManager.LoadScene("FightScene");
        }
    }
}
