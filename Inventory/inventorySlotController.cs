using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventorySlotController : MonoBehaviour
{
    public Item item;
    //public Text displayText;
   // public Image displayImage;

    public void updateInfo()
    {
        
        Text displayText = transform.Find("ItemText").GetComponent<Text>();
        Image displayImage = transform.Find("ItemImage").GetComponent<Image>();

        if (item)
        {
            displayText.text = item.itemName;
            displayImage.sprite = item.icon;
            displayImage.color = Color.white;
            Debug.Log("You clicked: " + item.itemName);
        }
        else
        {
            displayText.text = "";
            displayImage.sprite = null;
            displayImage.color = Color.clear;
        }
    }

    private void Start()
    {
       // updateInfo();
    }



}
