using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;

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


    //Option page
    public void CloseOption()
    {
        sceneFader.FadeTo("MainMenu");
    }
    //HowToPlay page
    public void CloseHow2play()
    {
        sceneFader.FadeTo("MainMenu");
    }
    //Credit page
    public void CloseCredit()
    {
        sceneFader.FadeTo("MainMenu");
    }

    //Stage levels page
    public void lvl(string lvlName)
    {
        sceneFader.FadeTo(lvlName);
    }

}
