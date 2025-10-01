using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_script : MonoBehaviour
{
    public GameObject player;
    food_counter food_Counter1;
    private void Start()
    {
        food_Counter1 =player.GetComponent<food_counter>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            food_Counter1.counter += 1;
        }
    }
}
