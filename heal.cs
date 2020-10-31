using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
using System;
using UnityEngine.SceneManagement;

public class heal : MonoBehaviour
{
    public GameObject T;
    public int MANA = 100;
    public int CurrentMANA;
    private int bigH = 20;
    private int smallH = 15;
    private int n = 0;
    private int rand;

    private float SmallhealCD;
    private float freespellCD;
    private float BighealCD;

    Boolean Smallheal()
    {
        if (CurrentMANA >= 5)
        {
            (whichone()).GetComponent<Heath>().Takeheal(smallH);
            Debug.Log("heal " + smallH + " to " + (whichone()).name);
            CurrentMANA -= 5;
            return true;
        }
        return false;
    }



    void freespell()     //lv1奶妈就把这玩意删了 //已改成除了level1都释放
    {
        //If it is not in the level one, trigger the following
        if (!SceneManager.GetActiveScene().name.Equals("Level1")) 
        {      
            if (T.GetComponent<Heath>().CurrentHP <= 1500)
            {
                System.Random rm = new System.Random();
                int number = rm.Next(0, 1);
                if (number == 1)
                {
                   Smallheal();
                   CurrentMANA += 5;                
                }
                else
                {
                    Bigheal();
                    CurrentMANA += 8;                
                }
            }
        }
    }




    Boolean Bigheal()
    {
        if (CurrentMANA >= 8)
        {
            T.GetComponent<Heath>().Takeheal(bigH);
            Debug.Log("heal " + bigH + " to " + T.name);
            CurrentMANA -= 8;
            return true;
        }
        return false;
    }


    void Start()
    {
        gameObject.GetComponent<Heath>().IsH = 1;
        CurrentMANA = MANA;

        SmallhealCD = 2;
        freespellCD = 3;
        BighealCD = 5;

}

    GameObject whichone()
    {
        GameObject[] Friend;
        Friend = GameObject.FindGameObjectsWithTag("Freindly");
        GameObject[] needHeal = null;

        for (int i = 0; i < 5; i++)
        {
            if (Friend[i].GetComponent<Heath>().fullH > 0)
            {
                needHeal[n] = Friend[i];
                n++;
                if (Friend[i].GetComponent<Heath>().IsH == 1)
                {
                    needHeal[n] = Friend[i];
                    n++;
                }
            }
        }

        rand = (n - 1);
        System.Random rm = new System.Random();
        int number = rm.Next(0, rand);
        return needHeal[number];
    }




    void Update()
    {
        SmallhealCD -= Time.deltaTime;
        freespellCD -= Time.deltaTime;
        BighealCD -= Time.deltaTime;
    
    
    
        if (SmallhealCD <= 0) 
        {
            if (Smallheal() == true)
            {
                SmallhealCD = 2;
            }

        }

        if (BighealCD <= 0)
        {
            if (Bigheal() == true)
            {
                BighealCD = 5;
            }

        }

        if (freespellCD <= 0)
        {
            freespell();
            freespellCD = 3;
        } 

        if (CurrentMANA < MANA)
        {
            CurrentMANA += 2;
        }
        
    }
}
