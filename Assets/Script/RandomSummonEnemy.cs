using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSummonEnemy : MonoBehaviour
{
    public GameObject EnemyObject;
    public float xPos;
    //public float xPos_min;
    //public float xPos_max;
    public float zPos;
    //public float zPos_min;
    //public float zPos_max;
    private float yRotation;
    public float yRot_max;
    private int EnemyCount = 1;
    //public int EnemyAmount;

    
    void Start()
    {
        StartCoroutine(EnemySummon());
    }

    IEnumerator EnemySummon()
    {
        while(EnemyCount <= 1) //change num of enemy needed
        {
        //xPos = Random.Range(xPos_min,xPos_max); //change range needed
        //zPos = Random.Range(zPos_min,zPos_max); //change range needed
        yRotation = Random.Range(0,yRot_max);
        Instantiate(EnemyObject, new Vector3(xPos,1,zPos),Quaternion.Euler(0,yRotation,0)); //change yPos needed
        yield return new WaitForSeconds(0.25f); //can change delay time
        EnemyCount++;
        }
    }
}
