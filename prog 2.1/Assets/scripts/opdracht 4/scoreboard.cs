using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{
    private Text text;
    private int score;
    void Start()
    {
        text = GetComponent<Text>();
        Pickup.pickedup += ChangeScore;
    }

    void Update()
    {
        
    }
    private void ChangeScore()
    {
        score += 50;
        text.text = score.ToString();
    }
}
