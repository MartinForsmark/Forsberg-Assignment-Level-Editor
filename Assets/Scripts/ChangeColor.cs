using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    public GameObject inputFieldColor;
    public GameObject inputFieldColor2;
    public GameObject Water;
   


    public void changeColor()
    {
        if (inputFieldColor.GetComponent<InputField>().text == "Fire")
        {
            Water.GetComponent<Image>().color = Color.red;
        }
    }
}
