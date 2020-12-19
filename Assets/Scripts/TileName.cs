using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileName : MonoBehaviour
{
    public string Name;
    public string Name2;
    public GameObject inputFieldName;
    public GameObject inputFieldName2;
    public Text WaterText;
    public Text GrassText;

    public void StoreName()
    {
        Name = inputFieldName.GetComponent<InputField>().text;
        WaterText.text = Name;
    }

    public void StoreName2()
    {
        Name2 = inputFieldName2.GetComponent<InputField>().text;
        GrassText.text = Name2;
    }
}
