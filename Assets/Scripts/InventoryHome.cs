using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHome : MonoBehaviour
{

    public PlayerController pc;
    public Text textMoneyAmount; 

    


    // Update is called once per frame
    void Update()
    {
      textMoneyAmount.text = pc.money.ToString();
    }
}
