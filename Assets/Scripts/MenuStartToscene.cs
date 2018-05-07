using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuStartToscene : MonoBehaviour
{

    public void ButtonClicked()
    {
        // Load the next scene.
        SceneManager.LoadScene("scene");
    }
}
