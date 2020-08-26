using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Item; //Accessing Item.cs


public class inventorySlotController : MonoBehaviour
{
    public Item item;


    public void updateInfo()
    {
        
        Text displayText = transform.Find("ItemText").GetComponent<Text>();
        Image displayImage = transform.Find("ItemImage").GetComponent<Image>();
       
        if (item)
        {
            
            displayText.text = item.itemName;
            displayImage.sprite = item.icon;
            displayImage.color = Color.white;
        }
        else
        {
            displayText.text = "";
            displayImage.sprite = null;
            displayImage.color = Color.clear;
        }
    }

  
    
    public void Use()
    {

        Debug.Log(item.CurrentItemType);
        switch (item.CurrentItemType)
        {
            case itemtype.WEAPON:
                {
                    if (item)
                    {
                        item.Use();
                        updateInfo();
                    }
                    break;
                }

            case itemtype.HEALTH:
                {             
                    if (item)
                    {
                        item.Use();
                        updateInfo();
                    }
                    break;                 
                }

            case itemtype.ARMOR:
                {
                    if (item)
                    {
                        item.Use();
                        updateInfo();
                    }
                    break;
                }
            case itemtype.AMMO:
                {
                    if (item)
                    {
                        item.Use();
                        updateInfo();
                    }
                    break;                 
                }
            case itemtype.EMPTY:
                {
                    if (item)
                    {
                        item.Use();
                        updateInfo();
                    }
                    break;
                }


            default:
                {
                    break;
                }
        }
     

        
    }

    private void Start()
    {
       updateInfo();
    }



}
