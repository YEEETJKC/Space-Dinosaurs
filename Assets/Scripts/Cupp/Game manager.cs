using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject deathScreen;
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
        deathScreen.SetActive(true);
    }
    public void Respawn()
    {
        player.transform.position = respawnPoint;
        player.SetActive(true);
        deathScreen.SetActive(false);
    }
}
