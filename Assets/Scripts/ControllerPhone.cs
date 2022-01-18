using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPhone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject parentShop; 
    public GameObject parentPhone; 
    public GameObject currentScreen;
    public GameObject ParentApps;

    public void InventoryAppClicked()
    {
        ParentApps.SetActive(false);

    }
    

    // Update is called once per frame
    void Update()
    {
        //PRESSING TAB TO OPEN CELL

        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            if (parentPhone.activeInHierarchy) 
            {
                parentPhone.SetActive(false);
                currentScreen.SetActive(true);
            }
            else
            {
                parentPhone.SetActive(true);
                currentScreen.SetActive(false);
            }
        }
    }
}
