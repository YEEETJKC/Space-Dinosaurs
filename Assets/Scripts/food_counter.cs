using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class food_counter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public float counter;
   

    
    public void Update()
    {
        
        counterText.text ="Food: " + counter.ToString();
    }

}