using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Armor")]
public class TypeArmor : Item
{
    public float givearmor = 0;

    public override void Use() //Armor Use Effect
    {
        Armor playerArmor = GameObject.Find("ArmorBar").GetComponent<Armor>();
        playerArmor.GiveArmor(givearmor);
        _Inventory.instance.Remove(this);
    }
}