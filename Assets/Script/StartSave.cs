using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSave : MonoBehaviour
{
    public GameObject playerPrefab;
    Player player;
    void Start()
    {
        GameObject playerGO = playerPrefab;
        player = playerGO.GetComponent<Player>();

        player.SavePlayer();
    }
}
