using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    // public string levelToLoad = "";

    public SceneFader sceneFader;
    // public void Play() {
    //     {
    //         sceneFader.FadeTo("Tutorial Lvl");
    //     }
        
    // }

    public void leave()
        {
            Application.Quit();
        }

    public void StartGame()
    {
        sceneFader.FadeTo("Tutorial Lvl");
    }

    public void OpenOption()
    {
        sceneFader.FadeTo("Options");
    }

    public void CloseOption()
    {
        //sceneFader.FadeTo();
    }

    public void How2play()
    {
        sceneFader.FadeTo("HowtoPlay");
    }

    public void CloseHow2play()
    {
        sceneFader.FadeTo("MainMenu");
    }

    public void Credit()
    {
        sceneFader.FadeTo("credits");
    }

    public void CloseCredit()
    {
        sceneFader.FadeTo("MainMenu");
    }
}
