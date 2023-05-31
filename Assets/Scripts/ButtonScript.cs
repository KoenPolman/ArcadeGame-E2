using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(3); // SampleScene Scene gets loaded (Game)
    }
    public void InsertCoins()
    {
        SceneManager.LoadScene(1); // MainMenu Scene gets loaded
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
