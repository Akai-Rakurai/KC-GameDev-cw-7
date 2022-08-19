using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public AudioSource SRC;

    void Start()
    {
        SRC = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SRC.Play();
            Invoke("Restart", 1.5f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(2);
    }
}
