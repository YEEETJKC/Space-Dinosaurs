using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlescenescript : MonoBehaviour
{
    public string what_scene;
    // Start is called before the first frame update
    public void skift()
    {
        SceneManager.LoadScene(what_scene);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
