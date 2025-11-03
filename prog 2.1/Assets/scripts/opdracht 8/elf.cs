using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elf : EnemyParent
{
    private Renderer thisRenderer;
    void Start()
    {
        thisRenderer = GetComponent<Renderer>();
        hp = 3;
        speed = 3;
        rb = GetRb();
        StartCoroutine(invisibility());
    }

    void FixedUpdate()
    {
        MoveRight();
    }

    private IEnumerator invisibility()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            thisRenderer.enabled = false;
            yield return new WaitForSeconds(0.5f);
            thisRenderer.enabled = true;
        }
    }
}
