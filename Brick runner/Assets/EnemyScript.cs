using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    Rigidbody RB;
    public float speed;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        move();
    }
    void move()
    {
        RB.velocity = new Vector3(0, 0, speed);
        
    }
    
}
