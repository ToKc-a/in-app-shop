using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    void Start()
    {
        GameObject ship = Instantiate(GameObject.FindObjectOfType<ShipArray>().shipPrefabs[GameManager.SHIPINDEXCHECK]);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
