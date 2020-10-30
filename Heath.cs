using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    private int MaxHP = 100;  
    public int CurrentHP;
    public int fullH=0;
    public int IsHealer = 0;


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

    public void Takeheal(int H)
    {

        CurrentHP += H;
        Debug.Log(gameObject.name + " take " + H + " heal " + "hp=" + CurrentHP);
      
    }


    void Update()
    {

        if (CurrentHP < MaxHP)
        {
            fullH = 1;
        }
        else
        {
            fullH = 0;
        }

    }


}
