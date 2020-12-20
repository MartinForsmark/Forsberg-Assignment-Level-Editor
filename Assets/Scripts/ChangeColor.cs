using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    public GameObject inputFieldColor;
    public GameObject imageColor;
    public Color oldColor;

    public void changeColor()
    {
        oldColor = imageColor.GetComponent<Image>().color;
        if (inputFieldColor.GetComponent<InputField>().text == "Red") {
            imageColor.GetComponent<Image>().color = Color.red;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.red);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Pink") {
            imageColor.GetComponent<Image>().color = Color.magenta;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.magenta);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Yellow") {
            imageColor.GetComponent<Image>().color = Color.yellow;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.yellow);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Blue") {
            imageColor.GetComponent<Image>().color = Color.blue;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.blue);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Black") {
            imageColor.GetComponent<Image>().color = Color.black;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.black);
        }
        
        else if (inputFieldColor.GetComponent<InputField>().text == "Gray") {
            imageColor.GetComponent<Image>().color = Color.gray;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.gray);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Cyan") {
                imageColor.GetComponent<Image>().color = Color.cyan;
                FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.cyan);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "White") {
            imageColor.GetComponent<Image>().color = Color.white;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.white);
        }
        
        else if(inputFieldColor.GetComponent<InputField>().text == "Green") {
            imageColor.GetComponent<Image>().color = Color.green;
            FindObjectOfType<ChangeColorOnTiles>().ChangeColorTiles(oldColor, Color.green);
        }
        
    }
}
