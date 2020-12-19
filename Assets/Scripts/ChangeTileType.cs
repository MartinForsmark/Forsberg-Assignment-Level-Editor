using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeTileType : MonoBehaviour
{
    public StoreColorData ColorData;

    public void Start()
    {
        ColorData = FindObjectOfType<StoreColorData>();
    }

    public void ChangeTileColor()
     {
         EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = ColorData.ChangeColor; // checks what game object that is pressed/clicked on
     }
}
