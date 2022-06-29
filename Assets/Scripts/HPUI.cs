using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPUI : MonoBehaviour
{
    
    public Text hpText;

    // Update is called once per frame
    void Update()
    {
        hpText.text = " Health Points: " + PlayerStats.HealthPoints.ToString();
        
    }
}
