using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarTest : MonoBehaviour
{
    private Health healthBar;

    void Awake()
    {
        healthBar = GameObject.Find("HealthBar").GetComponent<Health>();
    }

   
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    if(HealthBarController.IsTest == true)
        //    {
        //        healthBar.changeHP(-5);
        //        Debug.Log("Çağırdı");
        //    }
          
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    healthBar.changeHP(+5);
        //    Debug.Log("Çağırdı");
        //}
    }
}
