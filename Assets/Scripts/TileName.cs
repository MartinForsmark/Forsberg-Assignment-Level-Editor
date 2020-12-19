using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileName : MonoBehaviour
{
    public string Name;
    public string Name2;
    public GameObject inputField;
    public GameObject inputField2;
    public Text WaterText;
    public Text GrassText;
    public GameObject Water;
    public GameObject Grass;

    public void StoreName()
    {
        Name = inputField.GetComponent<InputField>().text;
        WaterText.text = Name;
        if (inputField.GetComponent<InputField>().text == "Fire")
        {
            Water.GetComponent<Image>().color = Color.red;
        }

    }

    public void StoreName2()
    {
        Name2 = inputField2.GetComponent<InputField>().text;
        GrassText.text = Name2;
        if (inputField2.GetComponent<InputField>().text == "Fire")
        {
            Grass.GetComponent<Image>().color = Color.red;
        }
    }

}
