using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Item : ScriptableObject
{

    public enum itemtype { WEAPON, ARMOR,HEALTH,AMMO,EMPTY }
    public itemtype ItemType;
    public string itemName;
    public Sprite icon;
    public int ItemAmount;
    public bool isStackable;
    public bool isConsumable;



    public virtual Item GetCopy()
    {
        return this;
    }

    public itemtype CurrentItemType   
    {
        get { return ItemType; }   
        set { ItemType = value; }  
    }


    public virtual void Use()
    {

    }

   


}
