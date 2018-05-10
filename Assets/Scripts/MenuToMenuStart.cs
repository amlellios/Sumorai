using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuToMenuStart : MonoBehaviour
{

    public void OnStartClick()
    {
        SceneManager.LoadScene("MenuStart");
    }
   
    public void OnQuitClick()
    {
        Application.Quit();
    }
}
