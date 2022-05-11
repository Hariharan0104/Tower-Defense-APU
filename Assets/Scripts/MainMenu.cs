using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public SceneFader sceneFader;
    
   
    //UI buttons in main menu pg
    public void StartGame()
    {
        sceneFader.FadeTo("Stage Lvl");
    }

     public void leave()
    {
        Application.Quit();
    }

    public void Option()
    {
        sceneFader.FadeTo("Options");
    }
    
    public void How2play()
    {
        sceneFader.FadeTo("HowtoPlay");
    }

    public void Credit()
    {
        sceneFader.FadeTo("credits");
    }



    public void CloseOption()
    {
        //sceneFader.FadeTo();
    }

    public void CloseHow2play()
    {
        sceneFader.FadeTo("MainMenu");
    }

    public void CloseCredit()
    {
        sceneFader.FadeTo("MainMenu");
    }
}
