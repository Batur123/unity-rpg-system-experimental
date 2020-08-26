using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    private Slider healthBar;
    public float currentHealth=50, maxHealth=100;

    void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    void Update()
    {
        healthBar.value = currentHealth;
    }
    
    public void Heal(float amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            maxHealth = currentHealth;
        }

        healthBar.value = currentHealth;

    }

}
