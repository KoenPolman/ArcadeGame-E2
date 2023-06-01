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
        SceneManager.LoadScene(1); // insertCoin Scene gets loaded
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0); // main menu gets loaded
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
