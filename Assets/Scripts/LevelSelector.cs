using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] lvlButtons;

    void Awake()
    {
        //PlayerPrefs.DeleteAll();
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (var i = 0; i < lvlButtons.Length; i++)
        {
            if(i + 1 > levelReached)
            {
                lvlButtons[i].interactable = false;
            }
            
        }
    }
    //use this at end of every levels
    // public void WinLevel()
    // {
    //     PlayerPrefs.SetInt("levelReached", 2);
        
    // }
}
