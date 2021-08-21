using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreManager : MonoBehaviour
{
    public static StoreManager instance;

    public GameObject cardPanelPrefab;
    public GameObject scrollArea;
    public Text coinCountText;
    public Text crystalCountText;
    public GameObject notEnoughMoneyPanel;
    public GameObject equippedShipPanel;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void Awake()
    {
        MakeInstance();
        MakeCardPanels();
        AddScrollAbilities();
    }

    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }

    void AddScrollAbilities()
    {
        scrollArea.AddComponent<ScrollRect>();
        scrollArea.GetComponent<ScrollRect>().vertical = false;
        scrollArea.GetComponent<ScrollRect>().movementType = ScrollRect.MovementType.Elastic;

        RectTransform scrollTransform = GameObject.Find("Card Holder").GetComponent<RectTransform>();
        float scrollLength = 400 * GameManager.instance.GetComponent<ShipArray>().shipPrefabs.Length;
        scrollTransform.sizeDelta = new Vector2(scrollLength, 0);
        scrollArea.GetComponent<ScrollRect>().content = scrollTransform;
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

    void Update()
    {
        coinCountText.text = GameManager.CoinCount.ToString();
        crystalCountText.text = GameManager.CrystalCount.ToString();
    }

    public void CloseNotEnoughMoneyPanel()
    {
        StoreManager.instance.notEnoughMoneyPanel.gameObject.SetActive(false);
    }

    public void EquippedNewShip(string shipName, Sprite shipImage)
    {
        equippedShipPanel.GetComponentInChildren<Text>().text = shipName;
        GameObject g = GameObject.Find("Ship Image");

        if(g.transform.parent.name == "Equipped Panel")
        {
            GameObject.Find("Ship Image").GetComponent<Image>().sprite = shipImage;
        }

        StartCoroutine(EquippedNewShipAnimationWait());
    }

    IEnumerator EquippedNewShipAnimationWait()
    {
        equippedShipPanel.GetComponent<Animator>().Play("EquippedPanelAnimIn");
        yield return new WaitForSeconds(1.5f);
        equippedShipPanel.GetComponent<Animator>().Play("EquippedPanelAnimOut");
    }
}
