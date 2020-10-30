using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    public GameObject T;
    public MANA=100;
    public CurrentMANA;
    private int bigH = 20;
    private int smallH = 15;
  

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

     GameObject which()
    {
        GameObject Friend[5] = GameObject.FindGameObjectWithTag("friendly");
        GameObject needHeal[];
        private int n = 0;
        for(int i = 0; i< 5; i++)
        {
           if(Friend[i] .GetComponent<Heath>().fullH > 0)
            {
                neeedHeal[n]=Friend[i];
                n++;
                if(Friend[i].GetComponent<Heath>().IsHear=1;)
                {
                 neeedHeal[n]=Friend[i];
                 n++;
                }
             }
        }
          private int rand = (n-1);
        Random ran = new Random();
        int number = ran.Next(0, rand);
        return neeedHeal[number];
    }


    void Smallheal()
    {
         private GameObject D = which();
        D.GetComponent<Heath>().Takeheal(smallH)
        Debug.Log("heal " + smallH + " to " + D.name);
         CurrentMANA -= 5;
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
