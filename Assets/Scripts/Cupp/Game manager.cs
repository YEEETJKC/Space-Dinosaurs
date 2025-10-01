using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] GameObject deathScreen;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject menu;

    [SerializeField] GameObject player;
    private Vector2 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Death()
    {
        player.SetActive(false);
        canvas.SetActive(true);
        menu.SetActive(false);
        deathScreen.SetActive(true);
    }
    public void Respawn()
    {
        player.transform.position = respawnPoint;
        player.SetActive(true);
        deathScreen.SetActive(false);
    }
}
