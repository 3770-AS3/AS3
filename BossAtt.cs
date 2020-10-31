using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossAtt : MonoBehaviour
{
    

    public int dps = 50;
    public int aoeDps = 12;
    public int damageInThisTimeStep; //It has to add 100th of to total damage first, then attack.

    public float totalDmg;
    private int addDmg;

    private float attackCD;
    private float aoeCD;

    public GameObject Tank;
    //All players who take aoe demage. 
    public GameObject Rogue;
    public GameObject Mage;
    public GameObject Druid;
    public GameObject Priest;

    void Start()
    {
       Tank = GameObject.Find("Tank");
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
        if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            extraDamageInLevel3();
        }
        else 
        {
            damageInThisTimeStep = dps;
        }
       
        Debug.Log("make " + totalDmg + " to " + T.name);

        Tank.GetComponent<Heath>().TakeDamage(damageInThisTimeStep);

        //Update total damage after deal damage.
        totalDmg += damageInThisTimeStep;
   
    }

    void aoeAttack() 
    {
        //Aoe damage to 5 players
        
        Rogue.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;

        Mage.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;

        Druid.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;

        Priest.GetComponent<Heath>().TakeDamage(aoeDps);
        totalDmg += aoeDps;
    }

    void extraDamageInLevel3() 
    {
        addDmg = (int)(totalDmg / 100);
        damageInThisTimeStep = dps + addDmg;
    }


}