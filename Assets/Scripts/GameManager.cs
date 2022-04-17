using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
 private bool gameEnded = false;

    // Update is called once per frame
    void Update()
    {
        if(gameEnded)
        return;

        if(PlayerStats.Lives <= 0 )
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log ("End");
    }

    //on click -- PlayerStats.Money += 10 (points)
}
