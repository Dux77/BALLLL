using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    AudioManager audioManager;
    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Game Over
            audioManager.Play("gameOver");
            PlayerManager.gameOver = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gem"))
        {
            audioManager.Play("coin");
            PlayerManager.gems++;
            PlayerManager.score++;
            Destroy(other.gameObject);
        }
    }
}
