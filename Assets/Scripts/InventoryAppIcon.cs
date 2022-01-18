using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAppIcon : MonoBehaviour
{
    public ControllerPhone cp;

    void OnMouseDown() 
    {
        cp.InventoryAppClicked();
    }
}
