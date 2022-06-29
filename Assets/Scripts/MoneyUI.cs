using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//    MONEY DOESNT WORK !!!!
public class MoneyUI : MonoBehaviour
{
    public Text moneyText;

    void Update()
    {
        moneyText.text = " Money: " + PlayerStats.Money.ToString();
        
    }
}
