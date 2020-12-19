using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColorData : MonoBehaviour
{
    public Color ChangeColor;
    
    
    public void ChangeWaterColor()
    {
        ChangeColor = Color.blue;            
    }

    public void ChangeGrassColor()
    {
        ChangeColor = Color.green;
    } 
}
