using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armor : MonoBehaviour
{
    private Slider armorBar;
    public float currentArmor = 50, maxArmor = 100;

    void Awake()
    {
        armorBar = GetComponent<Slider>();
    }

    void Update()
    {
        armorBar.value = currentArmor;
    }

    public void GiveArmor(float amount)
    {
        currentArmor += amount;

        if (currentArmor > maxArmor)
        {
            maxArmor = currentArmor;
        }

        armorBar.value = currentArmor;

    }
}
