using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text coinText;
    int coins = 3;

    //private void Start()
    //{
    //    coins = PlayerPrefs.GetInt("Coins", coins);
    //    coinText.text = coins.ToString();
    //}
    public void StartGame()
    {
        PlayerPrefs.GetInt("Coins", coins);
        if (coins >= 1)
        {
            SceneManager.LoadScene(3); // SampleScene Scene gets loaded (Game)
        }
        else
        {
            print("You don't have enough coins");
        }
    }
    public void InsertCoins()
    {
        SceneManager.LoadScene(1); // MainMenu Scene gets loaded
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
