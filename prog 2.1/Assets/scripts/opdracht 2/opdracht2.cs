using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class opdracht2 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);
            Vector3 position = new Vector3 (x, 0, z);
            PlaceTower(position);
        }
    }
    private void PlaceTower(Vector3 position)
    {
        float x = Random.Range(0.2f, 2f);
        float y = Random.Range(0.2f, 2f);
        float z = Random.Range(0.2f, 2f);
        GameObject thisprefab = Instantiate(prefab, position, Quaternion.identity);
        thisprefab.transform.localScale = new Vector3(x, y, z);
    }
}
