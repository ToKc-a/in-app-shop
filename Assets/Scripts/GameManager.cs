using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int CoinCount { get { return PlayerPrefs.GetInt("CoinCount"); } set { PlayerPrefs.SetInt("CoinCount", value); } }
    public static int CrystalCount { get { return PlayerPrefs.GetInt("CrystalCount"); } set { PlayerPrefs.SetInt("CrystalCount", value); } }

    void Awake()
    {
        MakeSingleton();
    }

    void MakeSingleton()
    {
        if (instance !=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        if(!PlayerPrefs.HasKey("HASPLAYEDGAMEBEFORE"))
        {
            PlayerPrefs.SetInt("HASPLAYEDGAMEBEFORE", 0);
            PlayerPrefs.SetInt("CoinCount", 0);
            PlayerPrefs.SetInt("CrystalCount", 0);
        }

    }
}
