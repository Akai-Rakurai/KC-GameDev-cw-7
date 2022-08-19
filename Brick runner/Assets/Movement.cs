using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float inc;
    public float Min;
    public float Max;
    void Start()
    {
        
    }

    void Update()
    {
        move();
    }

    private void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, Min, Max), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, Min, Max), transform.position.y, transform.position.z);
        }
    }
}
