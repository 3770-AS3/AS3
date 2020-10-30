using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Essentially,This class is a tool box for using Updater without define Text Objects.
//Whichever class wants to use this Manager, first define "Manager M;" in the class, 
//and then define M by using "M = GameObject.Find("Target Object").GetComponent<Manager>();" in the void start().
public class Manager : MonoBehaviour
{
    Updater UM;

    GlobalScore GS;

    private void Start()
    {
        //This works if Updater class and Manager are in the same Object(could put them in an empty object);
        //If they are not in same object use "UM = GameObject.Find("Target Object").GetComponent<Updater>();" Same for GS;

        UM = GetComponent<Updater>();

        GS = GetComponent<GlobalScore>();
    }

    //Uses methods in Updater to update total damage. 
    public void BossDeal(float demage)
    {
        UM.BossDealDamage(demage);
    }

    public void WarriorDeal(float damage)
    {
        UM.WarriorDealDamage(damage);
    }

    public void RogueDeal(float damage)
    {
        UM.RogueDealDamage(damage);
    }

    public void MageDeal(float damage)
    {
        UM.MageDealDamage(damage);
    }

    public void DruidDeal(float damage)
    {
        UM.DruidDealDamage(damage);
    }

    //Uses methods in Updater to update current heath. 
    public void BossCurHealth(float health) 
    {
        UM.BossCurrentHealth(health);
    }
    public void WarriorCurHealth(float health)
    {
        UM.WarriorCurrentHealth(health);
    }
    public void RogueCurHealth(float health)
    {
        UM.RogueCurrentHealth(health);
    }
    public void MageCurHealth(float health)
    {
        UM.MageCurrentHealth(health);
    }
    public void DruidCurHealth(float health)
    {
        UM.DruidCurrentHealth(health);
    }
    public void PriestCurHealth(float health)
    {
        UM.PriestCurrentHealth(health);
    }

    //Get total damge of party and boss for some class that needs it.
    public float getTotalPartyToBoss() 
    {
        return UM.GetTotalDemegePartyToBoss();
    }
    public float getTotalBossToParty()
    {
        return UM.GetTotalDemageBossToParty();
    }

    //Update methods for the globalScore Class
    public void UpdateBeforeSwitchScene(float totalP2B, float totalB2P) 
    {
        GS.CheckAndUpdateScoreClass(totalP2B, totalB2P);
    }
}
