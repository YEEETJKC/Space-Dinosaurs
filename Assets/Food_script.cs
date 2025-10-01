using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_script : MonoBehaviour
{
    public GameObject player;
    public food_counter foodCounter;
    private void Start()
    {
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

       

        if(collision.tag == "Player")
        {
            foodCounter.counter += 1;
        }
    }
}
