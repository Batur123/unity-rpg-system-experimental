using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpenClose : MonoBehaviour
{
    public static void Menu()
    {    

        if (Input.GetKeyDown(KeyCode.Tab))
        {

            GameObject isOpen = _Inventory.instance.inventoryPanel;

            if (!isOpen.activeSelf)
            {
                isOpen.SetActive(true);
            }
            else
            {
                isOpen.SetActive(false);
            }
        }
    }


}
