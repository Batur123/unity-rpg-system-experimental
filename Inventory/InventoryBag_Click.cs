using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryBag_Click : MonoBehaviour
{
    public Button UI_InventoryBag;
    


    void Start()
    {
        
        Button btn = UI_InventoryBag.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
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
