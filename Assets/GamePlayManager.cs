using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    // Start is called before the first frame update

    private bool gameIsEnded = false;

    // Update is called once per frame
    void Update()
    {
        if(gameIsEnded)
        {
            return;
        }
        if(PlayerStats.HealthPoints <= 0)
        {
            EndGame();
        }
        
    }

    void EndGame()
    {
        gameIsEnded = true;
        UnityEngine.Debug.Log("YOU DIED");
    }
}
