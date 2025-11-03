using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht3 : MonoBehaviour
{
    private float timer = 0;
    [SerializeField] private GameObject enemy;
    private List<GameObject> enemies = new List<GameObject>();
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnEnemies(100);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveEnemies();
        }
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0f;
            SpawnEnemies(3);
        }
    }
    private void SpawnEnemies(int total)
    {
        for (int i = 0; i < total; i++)
        {
            enemies.Add(Instantiate(enemy, transform));
        }
    }
    private void RemoveEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }
}
