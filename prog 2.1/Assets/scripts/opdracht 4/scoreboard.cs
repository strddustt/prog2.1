using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{
    private Text text;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        Pickup.pickedup += ChangeScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ChangeScore()
    {
        score += 50;
        text.text = score.ToString();
    }
}
