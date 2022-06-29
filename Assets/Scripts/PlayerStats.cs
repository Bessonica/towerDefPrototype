using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int HealthPoints;
    public int startHealthPoints = 10;

    public static int Money;
    public int startMoney = 400;
    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        HealthPoints = startHealthPoints;
        
    }


}
