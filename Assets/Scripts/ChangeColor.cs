using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    public GameObject inputFieldColor;
    public GameObject imageColor;

    public void changeColor()
    {
        if (inputFieldColor.GetComponent<InputField>().text == "Red") {
            imageColor.GetComponent<Image>().color = Color.red;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Pink") {
            imageColor.GetComponent<Image>().color = Color.magenta;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Yellow") {
            imageColor.GetComponent<Image>().color = Color.yellow;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Blue") {
            imageColor.GetComponent<Image>().color = Color.blue;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Black") {
            imageColor.GetComponent<Image>().color = Color.black;
        }
        
        else if (inputFieldColor.GetComponent<InputField>().text == "Gray") {
            imageColor.GetComponent<Image>().color = Color.gray;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Cyan") {
                imageColor.GetComponent<Image>().color = Color.cyan;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "White") {
            imageColor.GetComponent<Image>().color = Color.white;
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Green") {
            imageColor.GetComponent<Image>().color = Color.green;
        }
        
    }
}
