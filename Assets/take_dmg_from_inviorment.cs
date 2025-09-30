using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take_dmg_from_inviorment : MonoBehaviour
{
    public GameObject death_screen;
    public GameObject Cam;

    
    // Start is called before the first frame update
    void Start()
    {
        death_screen.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            death_screen.SetActive(true);
            Instantiate(Cam);
        }
    }
}
