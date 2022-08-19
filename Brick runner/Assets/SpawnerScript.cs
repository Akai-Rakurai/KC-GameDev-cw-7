using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Enemy2;

    public float Delay;

    public Transform LeftPos;
    public Transform RightPos;
    public Transform MiddlePos;

    public AudioSource SRC;

    void Start()
    {
        InvokeRepeating("spawn", 1f, Delay);
        SRC = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    void spawn()
    {
        int RandomPos = Random.Range(1, 4);
        if(RandomPos == 1)
        {
            Instantiate(Enemy2, MiddlePos);
        }
        else if(RandomPos == 2)
        {
            Instantiate(Enemy2, RightPos);
        }
        else if(RandomPos == 3)
        {
            Instantiate(Enemy2, LeftPos);
        }
    }


}
