using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowpoke : MonoBehaviour
{
    [SerializeField] PlayerController player;
    float speed;
    void Start()
    {
        speed = player.maxSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.maxSpeed = speed * 0.5f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.maxSpeed = speed;
    }
}
