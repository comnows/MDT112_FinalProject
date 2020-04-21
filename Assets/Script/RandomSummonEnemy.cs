using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSummonEnemy : MonoBehaviour
{
    public GameObject EnemyObject;
    private float xPos;
    private float zPos;
    private int EnemyCount = 1;

    
    void Start()
    {
        StartCoroutine(EnemySummon());
    }

    IEnumerator EnemySummon()
    {
        while(EnemyCount <= 10) //change num of enemy needed
        {
        xPos = Random.Range(0,0); //change range needed
        zPos = Random.Range(0,0); //change range needed
        Instantiate(EnemyObject, new Vector3(xPos,1,zPos),Quaternion.identity); //change yPos needed
        yield return new WaitForSeconds(0.25f); //can change delay time
        EnemyCount++;
        }
    }
}
