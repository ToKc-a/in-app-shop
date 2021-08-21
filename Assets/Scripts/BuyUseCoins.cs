using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUseCoins : MonoBehaviour
{
    private Button coinButton;

    void Awake()
    {
        coinButton = GetComponent<Button>();
        coinButton.onClick.AddListener(() => CheckButtonInfoCoin());
    }

    void CheckButtonInfoCoin()
    {
        switch ("" + coinButton.GetComponentInParent<CardPanel>().shipName.text)
        {
            case "Blue Ship":
                GameManager.SHIPINDEXCHECK = 0;

                StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[0].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[0]);
                break;

            case "Red Ship":
                if (GameManager.REDINDEXCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[1].GetComponent<Ship>().coinCost)
                    {
                        GameManager.REDINDEXCHECK = 1;
                        coinButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[1].GetComponent<Ship>().coinCost;
                        GameManager.SHIPINDEXCHECK = 1;

                        StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[1].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[1]);
                    }
                    else
                    {
                        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(true);
                    }
                }
                else
                {
                    GameManager.SHIPINDEXCHECK = 1;

                    StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[1].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[1]);
                }
                break;

            case "Yellow Ship":
                if (GameManager.YELLOWINDEXCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[2].GetComponent<Ship>().coinCost)
                    {
                        GameManager.YELLOWINDEXCHECK = 1;
                        coinButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[2].GetComponent<Ship>().coinCost;
                        GameManager.SHIPINDEXCHECK = 1;

                        StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[2].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[2]);
                    }
                    else
                    {
                        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(true);
                    }
                }
                else
                {
                    GameManager.SHIPINDEXCHECK = 2;

                    StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[2].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[2]);
                }
                break;

            case "Alien Ship":
                if (GameManager.ALIENINDEXCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[3].GetComponent<Ship>().coinCost)
                    {
                        GameManager.ALIENINDEXCHECK = 1;
                        coinButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[3].GetComponent<Ship>().coinCost;
                        GameManager.SHIPINDEXCHECK = 1;

                        StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[3].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[3]);
                    }
                    else
                    {
                        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(true);
                    }
                }
                else
                {
                    GameManager.SHIPINDEXCHECK = 3;

                    StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[3].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[3]);
                }
                break;

            case "Crystal Ship":
                if (GameManager.CRYSTALINDEXCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[4].GetComponent<Ship>().coinCost)
                    {
                        GameManager.CRYSTALINDEXCHECK = 1;
                        coinButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[4].GetComponent<Ship>().coinCost;
                        GameManager.SHIPINDEXCHECK = 1;

                        StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[4].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[4]);
                    }
                    else
                    {
                        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(true);
                    }
                }
                else
                {
                    GameManager.SHIPINDEXCHECK = 4;

                    StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[4].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[4]);
                }
                break;

            case "Pirate Ship":
                if (GameManager.PIRATEINDEXCHECK == 0)
                {
                    if (GameManager.CoinCount >= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[5].GetComponent<Ship>().coinCost)
                    {
                        GameManager.PIRATEINDEXCHECK = 1;
                        coinButton.GetComponentInChildren<Text>().text = "Use";
                        GameManager.CoinCount -= GameManager.instance.GetComponent<ShipArray>().shipPrefabs[5].GetComponent<Ship>().coinCost;
                        GameManager.SHIPINDEXCHECK = 1;

                        StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[5].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[5]);
                    }
                    else
                    {
                        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(true);
                    }
                }
                else
                {
                    GameManager.SHIPINDEXCHECK = 5;

                    StoreManager.instance.EquippedNewShip(
                    GameManager.instance.GetComponent<ShipArray>().shipPrefabs[5].gameObject.name,
                    GameManager.instance.GetComponent<ShipArray>().shipImages[5]);
                }
                break;
        }
    }
}
