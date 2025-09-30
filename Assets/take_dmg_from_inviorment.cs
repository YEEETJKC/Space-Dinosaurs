using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class take_dmg_from_inviorment : MonoBehaviour
{
    public GameObject death_screen;



    // Start is called before the first frame update
    void Start()
    {
        death_screen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            death_screen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
