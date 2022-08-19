using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Da_Wall : MonoBehaviour
{
    int Score;
    public Text text;
    void Start()
    {
        text.text = Score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Score++;
            text.text = Score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
