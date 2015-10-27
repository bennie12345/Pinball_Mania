using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    public void PlayGame()
    {
        Application.LoadLevel("Map");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu() 
    {
        Application.LoadLevel("Menu");
    }
}
