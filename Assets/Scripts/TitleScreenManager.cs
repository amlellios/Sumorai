using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("MenuStart");
    }
    public void OnCreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }
    public void OnQuitClick()
    {
        Application.Quit();
    }
    public void OnNextClick()
    {
        SceneManager.LoadScene("scene");
    }
}
