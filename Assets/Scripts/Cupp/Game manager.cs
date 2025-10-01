using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] GameObject deathScreen;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject Buttons;

    [SerializeField] GameObject player;
    bool visibleMenu = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!visibleMenu)
            {
                menu.SetActive(true);
                Buttons.SetActive(true);
                canvas.SetActive(true);
                deathScreen.SetActive(false);
                visibleMenu = true;
            }else
            {
                menu.SetActive(false);
                Buttons.SetActive(false);
                canvas.SetActive(false);
                deathScreen.SetActive(false);
                visibleMenu = false;
            }
            
        }
    }
    public void Death()
    {
        player.SetActive(false);
        canvas.SetActive(true);
        menu.SetActive(false);
        deathScreen.SetActive(true);
        Buttons.SetActive(false);
    }
}
