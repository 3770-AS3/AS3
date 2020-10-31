using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;

public class BossAtt : MonoBehaviour
{
    public GameObject T;

    public int dps = 50;
    public int aoeDps = 12;
    public int damageInThisTimeStep; //It has to add 100th of to total damage first, then attack.

    public float totalDmg;
    private int addDmg;

    private float attackCD;
    private float aoeCD;

    //all players who take aoe demage.
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;

    void Start()
    {
       T = GameObject.Find("Tank");
       totalDmg = 0;
       addDmg = 0;
       damageInThisTimeStep = 0;
       attackCD = 2;
       aoeCD = 5;
    }   

// Update is called once per frame
    void Update()
    {
        //When CD <= 0, Do it then reset.
        attackCD -= Time.deltaTime;
        aoeCD -= Time.deltaTime;
        if (attackCD <= 0) 
        {
            attacktarget();
            attackCD = 2;
        }
        if (aoeCD <= 0)
        {
            aoeAttack();
            aoeCD = 5;
        }
    }
    void attacktarget()
    {
        //totalDmg += dps;
        addDmg = (int)(totalDmg / 100);
        damageInThisTimeStep = dps + addDmg;
       
        Debug.Log("make " + totalDmg + " to " + T.name);

        T.GetComponent<Heath>().TakeDamage(damageInThisTimeStep);

        //Update total damage after deal damage.
        totalDmg += damageInThisTimeStep;
   
    }

    void aoeAttack() 
    {
        //Aoe damage to 5 players
        p1.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
        p2.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
        p3.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
        p4.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
        p5.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
    }


}