using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    private int MaxHP = 100;  
    public int CurrentHP;

    private void Start()
    {
        CurrentHP = MaxHP;
    }

    public void TakeDamage(int damage)
    {

        CurrentHP -= damage;
        Debug.Log(gameObject.name +" take " + damage +" damge "+"hp="+CurrentHP);
        if (CurrentHP <= 0)
        {
           Debug.Log(gameObject.name + "dia");
           Destroy(this.gameObject);
        }
    }
   
}
