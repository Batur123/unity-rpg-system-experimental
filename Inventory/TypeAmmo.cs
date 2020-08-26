using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Ammo")]
public class TypeAmmo : Item
{

    public override void Use() //Ammo Use Effect
    {
        //Health playerHealth = GameObject.Find("HealthBar").GetComponent<Health>();
        //playerHealth.Heal(heal);
        //_Inventory.instance.Remove(this);

        Debug.Log("This worked - ammo");

    }
}

