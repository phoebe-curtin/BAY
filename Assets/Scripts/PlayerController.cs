using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int money = 0; 
    
    //inventory

    public int medicine = 0;
    public int food = 0;
    public int bullets = 0;
    public int boat = 0;

    public void GetItem(ItemType type){

        if(type == ItemType.medicine) {
            medicine++;
        } else if(type == ItemType.food) {
            food++;
        } else if(type == ItemType.bullets) {
            bullets++;
        } else if(type == ItemType.boat) {
            boat++;
        }

    }


    void Update()
    {
        
    }
}
