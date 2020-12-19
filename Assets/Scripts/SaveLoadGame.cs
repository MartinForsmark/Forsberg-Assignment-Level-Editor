using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class SaveLoadGame : MonoBehaviour
{
    public void saveGame()
    {
        //Save position
        foreach (var changeTileType in FindObjectsOfType<Image>())
        {
            PlayerPrefs.SetString(changeTileType.name, JsonUtility.ToJson(changeTileType.GetComponent<Image>().color));
        }
    }
    public void loadGame()
    {
        // Load Position
        foreach (var changeTileType in FindObjectsOfType<Image>())
        {
            changeTileType.color = JsonUtility.FromJson<Color>(PlayerPrefs.GetString(changeTileType.name, ""));
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}