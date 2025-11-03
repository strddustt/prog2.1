using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class opdracht1 : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateBall();
        }
        StartCoroutine(spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateBall()
    {
        Vector3 randposition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        GameObject ball = Instantiate(prefab, randposition, Quaternion.identity);
        Color color = SelectColor();
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", color);
    }
    private Color SelectColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }
    private IEnumerator spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            CreateBall();
        }
    }
}
