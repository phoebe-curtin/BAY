using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Item item; 
    PlayerController pc; 
    

    void Start() 
    {
        pc = GameObject.FindWithTag("PlayerController").GetComponent<PlayerController>();
    }


    public

    void Update()
    {
        
    }

    public void BuyingItem() {

        if (item.price <= pc.money) {
            pc.money -= item.price; 
            pc.GetItem(item.type);
        }
    }
}
