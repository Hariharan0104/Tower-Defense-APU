using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("Game Over");
    }

    //on click -- PlayerStats.Money += 10 (points)
}
