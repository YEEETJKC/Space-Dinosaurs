using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    public GameObject Game_Object;
    public GameObject titlet;
   public void thisIsTrueNow()
    {
        if (Game_Object.activeSelf) 
        {
            Game_Object.SetActive(false); 
            titlet.SetActive(true);
        }
        else
        {
            Game_Object.SetActive(true); 
            titlet.SetActive(false);
        }
    }
    
}
