using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StoreColorData : MonoBehaviour
{
    public Color ChangeColor;
    public static Color selectedColor;

    public void Start()
    {
        ChangeColor = Color.green;
    }

    public void ChangeColors()
    {
        selectedColor = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }
    
}
