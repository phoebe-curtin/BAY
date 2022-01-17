using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject parentShop; 
    public GameObject parentPhone; 

    // Update is called once per frame
    void Update()
    {

        //PRESSING TAB TO OPEN CELL

         if (Input.GetKeyDown(KeyCode.Tab)) {

             if (parentShop.activeInHierarchy) {
                 
                 parentShop.SetActive(false); 
                 parentPhone.SetActive(true);
                 


             } else {

                 parentShop.SetActive(true);
             }
             
         }
    }
}
