using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHome : MonoBehaviour
{

    public PlayerController pc;
    public Text textMoneyAmount; 
    public Text textFoodAmount; 
    public Text textBulletsAmount;
    public Text textMedicineAmount;

    


    // Update is called once per frame
    void Update()
    {
      //UPDATING INVENTORY
      
      textMoneyAmount.text = pc.money.ToString();
      textFoodAmount.text = pc.food.ToString();
      textBulletsAmount.text = pc.bullets.ToString();
      textMedicineAmount.text = pc.medicine.ToString();
    }
}
