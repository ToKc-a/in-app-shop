using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private const string SHIP_INDEX = "Ship Index";
    private const string BLUE_SHIP = "Blue Ship";
    private const string RED_SHIP = "Red Ship";
    private const string YELLOW_SHIP = "Yellow Ship";
    private const string ALIEN_SHIP = "Alien Ship";
    private const string CRYSTAL_SHIP = "Crystal Ship";
    private const string PIRATE_SHIP = "Pirate Ship";

    public static int CoinCount { get { return PlayerPrefs.GetInt("CoinCount"); } set { PlayerPrefs.SetInt("CoinCount", value); } }
    public static int CrystalCount { get { return PlayerPrefs.GetInt("CrystalCount"); } set { PlayerPrefs.SetInt("CrystalCount", value); } }

    public static int SHIPINDEXCHECK { get { return PlayerPrefs.GetInt(SHIP_INDEX); } set { PlayerPrefs.SetInt(SHIP_INDEX, value); } }
    public static int BLUEINDEXCHECK { get { return PlayerPrefs.GetInt(BLUE_SHIP); } set { PlayerPrefs.SetInt(BLUE_SHIP, value); } }
    public static int REDINDEXCHECK { get { return PlayerPrefs.GetInt(RED_SHIP); } set { PlayerPrefs.SetInt(RED_SHIP, value); } }
    public static int YELLOWINDEXCHECK { get { return PlayerPrefs.GetInt(YELLOW_SHIP); } set { PlayerPrefs.SetInt(YELLOW_SHIP, value); } }
    public static int ALIENINDEXCHECK { get { return PlayerPrefs.GetInt(ALIEN_SHIP); } set { PlayerPrefs.SetInt(ALIEN_SHIP, value); } }
    public static int CRYSTALINDEXCHECK { get { return PlayerPrefs.GetInt(CRYSTAL_SHIP); } set { PlayerPrefs.SetInt(CRYSTAL_SHIP, value); } }
    public static int PIRATEINDEXCHECK { get { return PlayerPrefs.GetInt(PIRATE_SHIP); } set { PlayerPrefs.SetInt(PIRATE_SHIP, value); } }

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

            PlayerPrefs.SetInt(BLUE_SHIP, 0);
            PlayerPrefs.SetInt(RED_SHIP, 0);
            PlayerPrefs.SetInt(YELLOW_SHIP, 0);
            PlayerPrefs.SetInt(ALIEN_SHIP, 0);
            PlayerPrefs.SetInt(CRYSTAL_SHIP, 0);
            PlayerPrefs.SetInt(PIRATE_SHIP, 0);
        }

    }
}
