using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
using System;
public class heal : MonoBehaviour
{
    public GameObject T;
    public int MANA=100;
    public int CurrentMANA;
    private int bigH = 20;
    private int smallH = 15;
    private int n = 0;
    private int rand;

    void Smallheal()
    {
        (whichone()).GetComponent<Heath>().Takeheal(smallH);
        Debug.Log("heal " + smallH + " to " + (whichone()).name);
        CurrentMANA -= 5;
    }

void Bigheal()
    {
        T.GetComponent<Heath>().Takeheal(bigH);
        Debug.Log("heal " + bigH + " to " + T.name);
        CurrentMANA -= 8;
    }


    void Start()
    {
        gameObject.GetComponent<Heath>().IsH = 1;
        CurrentMANA = MANA;
    }

     GameObject whichone()
    {
        GameObject[] Friend;
        Friend = GameObject.FindGameObjectsWithTag("player");
        GameObject[] needHeal = null;
        
        for(int i = 0; i< 5; i++)
        {
           if(Friend[i] .GetComponent<Heath>().fullH > 0)
            {
                needHeal[n]=Friend[i];
                n++;
                if(Friend[i].GetComponent<Heath>().IsH==1)
                {
                 needHeal[n]=Friend[i];
                 n++;
                }
             }
        }
        
          rand = (n-1);
        System.Random rm = new System.Random();
        int number = rm.Next(0, rand);
        return needHeal[number];
    }




    void Update()
    {
         Smallheal();
        if (CurrentMANA < MANA)
        {
            CurrentMANA += 2;
        }

    }
}
