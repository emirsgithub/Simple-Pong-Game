using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public GameObject quitButton;

    public void quitGame()
    {
        Application.Quit();
    }
}
