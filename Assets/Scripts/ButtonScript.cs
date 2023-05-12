using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(0); // SampleScene Scene gets loaded (Game)
    }

    //public void Restart()
    //{
    //    SceneManager.LoadScene(2); // MainMenu Scene gets loaded
    //}

    public void InsertCoins()
    {
        SceneManager.LoadScene(0); // MainMenu Scene gets loaded
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
