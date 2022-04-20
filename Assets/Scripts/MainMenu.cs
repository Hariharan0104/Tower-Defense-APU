using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "";

    public SceneFader sceneFader;
    public void Play() {
        {
            sceneFader.FadeTo(levelToLoad);
        }
        
    }

    public void leave()
        {
            Application.Quit();
        }

    public void StartGame()
    {
        sceneFader.FadeTo("StageSelect");
    }

    public void OpenOption()
    {
        sceneFader.FadeTo("Options");
    }

    public void CloseOption()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void How2play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void CloseHow2play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Credit()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void CloseCredit()
    {
        sceneFader.FadeTo(levelToLoad);
    }
}
