using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject player;
    public static _Inventory instance;
    public List<Item> list = new List<Item>();

    void updatePanelSlots()
    {
        int index = 0;

        foreach(Transform child in inventoryPanel.transform)
        {
            
            inventorySlotController slot = child.GetComponent<inventorySlotController>();
            
            

            if (index < list.Count)
            {
                slot.item = list[index];
            }
            else
            {
                slot.item = null;
            }

            slot.updateInfo();
            index++;


        }
    }

    public void Add(Item item)
    {
        if(list.Count < 9)
        {
            list.Add(item);
        }
        updatePanelSlots();
    }

    public void Remove(Item item)
    {
        list.Remove(item);
        updatePanelSlots();

    }

    void Start()
    {
        instance = this;
        updatePanelSlots();
        
    }


}
