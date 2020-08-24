using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Prototype. Not Usable for now
    //-batur
    public float currentHealth, maxHealth;

    public void Heal(float amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            maxHealth = currentHealth;
        }

       // healthbar.value = currentHealth / maxHealth;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
