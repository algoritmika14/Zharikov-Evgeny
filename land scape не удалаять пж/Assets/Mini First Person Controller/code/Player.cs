using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    //Մեթոդ, որը նվազեցնում է խաղացողի առողջությունը


    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
    }



}
