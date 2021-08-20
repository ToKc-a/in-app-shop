using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Text currentCoinText;
    public Text currentCrystalText;

    void Update()
    {
        currentCoinText.text = GameManager.CoinCount.ToString();
        currentCrystalText.text = GameManager.CrystalCount.ToString();
    }

    public void AddCoins()
    {
        GameManager.CoinCount++;
    }

    public void AddCrystals()
    {
        GameManager.CrystalCount++;
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToStore()
    {
        SceneManager.LoadScene("Store");
    }
}
