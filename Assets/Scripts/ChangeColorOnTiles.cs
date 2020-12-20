using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOnTiles : MonoBehaviour {
    public void ChangeColorTiles(Color oldColor, Color newColor)
    {
        foreach (var image in GetComponentsInChildren<Image>())
        {
            if (image.color == oldColor)
            {
                image.color = newColor;
            }
        }
    }
}
