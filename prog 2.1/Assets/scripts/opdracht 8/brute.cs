using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brute : EnemyParent
{

    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        speed = 1;
        rb = GetRb();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveRight();
    }
}
