using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreManager : MonoBehaviour
{
    public GameObject cardPanelPrefab;
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void Awake()
    {
        MakeCardPanels();
    }

    void MakeCardPanels()
    {
        for(int i = 0; i < GameManager.instance.GetComponent<ShipArray>().shipPrefabs.Length; i++)
        {
            GameObject card = Instantiate(cardPanelPrefab);

            card.gameObject.name = GameManager.instance.GetComponent<ShipArray>().shipPrefabs[i].gameObject.name + "Panel";

            card.transform.SetParent(GameObject.Find("Card Holder").transform);
            card.transform.localScale = new Vector3(.85f, .85f, .85f);

            card.GetComponent<CardPanel>().shipName.text = GameManager.instance.GetComponent<ShipArray>().shipPrefabs[i].gameObject.name;

            card.GetComponent<CardPanel>().shipImage.sprite = GameManager.instance.GetComponent<ShipArray>().shipImages[i];
            card.GetComponent<CardPanel>().shipImage.SetNativeSize();
            card.GetComponent<CardPanel>().shipImage.rectTransform.localScale = new Vector3(.4f, .4f, .4f);

            card.GetComponent<CardPanel>().shipPriceCoins.text = GameManager.instance.GetComponent<ShipArray>().shipPrefabs[i].GetComponent<Ship>().coinCost.ToString();
            card.GetComponent<CardPanel>().shipPriceCrystals.text = GameManager.instance.GetComponent<ShipArray>().shipPrefabs[i].GetComponent<Ship>().crystalCost.ToString();

            switch("" + GameManager.instance.GetComponent<ShipArray>().shipPrefabs[i].gameObject.name)
            {
                case "Blue Ship":
                    card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                    card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    break;
                case "Red Ship":
                    if(GameManager.REDINDEXCHECK == 0)
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Buy";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Buy";
                    }
                    else
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    }
                    break;
                case "Yellow Ship":
                    if (GameManager.YELLOWINDEXCHECK == 0)
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Buy";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Buy";
                    }
                    else
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    }
                    break;
                case "Alien Ship":
                    if (GameManager.ALIENINDEXCHECK == 0)
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Buy";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Buy";
                    }
                    else
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    }
                    break;
                case "Crystal Ship":
                    if (GameManager.CRYSTALINDEXCHECK == 0)
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Buy";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Buy";
                    }
                    else
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    }
                    break;
                case "Pirate Ship":
                    if (GameManager.PIRATEINDEXCHECK == 0)
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Buy";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Buy";
                    }
                    else
                    {
                        card.GetComponent<CardPanel>().buyAndUseButtonCoins.GetComponentInChildren<Text>().text = "Use";
                        card.GetComponent<CardPanel>().buyAndUseButtonCrystals.GetComponentInChildren<Text>().text = "Use";
                    }
                    break;

            }
        }
    }
}
