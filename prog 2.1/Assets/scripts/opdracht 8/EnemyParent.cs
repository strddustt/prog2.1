using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    [SerializeField] public float speed = 5;
    [SerializeField] public float hp = 10;
    internal Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    internal Rigidbody GetRb()
    {
        return GetComponent<Rigidbody>();
    }
    internal void MoveRight()
    {
        rb.MovePosition(rb.position + Vector3.right * speed * Time.fixedDeltaTime);
    }
    internal void LoseLives(float value)
    {
        hp -= value;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        LoseLives(1);
    }
}
