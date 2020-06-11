using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpHud : MonoBehaviour
{
    public GameObject playerprefab;
    public Slider expSlider;
    public Text levelText;
    Player player;
    void Start()
    {
        player = playerprefab.GetComponent<Player>();
    }

    void Update()
    {
        levelText.text = "Level " + player.level;
        expSlider.value = player.currentEXP;
        expSlider.maxValue = player.maxEXP;
    }
}
