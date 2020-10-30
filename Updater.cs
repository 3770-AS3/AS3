﻿using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
{
    //All needed objects here, used to update the total damage on the screen, and the health.
    //public GameObject TotalDamageBossDone;
    //public GameObject TotalDamageWarriorDone;
    //public GameObject TotalDamageRogueDone;
    //public GameObject TotalDamageMageDone;
    //public GameObject TotalDamageDruidDone;
    //public GameObject TotalPartyDone;
    //Health Objects here
    /*
    public GameObject BossHealth;
    public GameObject WarriorHealth;
    public GameObject RogueHealth;
    public GameObject MageHealth;
    public GameObject DruidHealth;
    public GameObject PriestHealth;
    */

    //Storing the Text objects.
    public Text TotalDamageBossDone_text;
    public Text TotalDamageWarriorDone_text;
    public Text TotalDamageRogueDone_text;
    public Text TotalDamageMageDone_text;
    public Text TotalDamageDruidDone_text;
    public Text TotalPartyDone_text;

    //values in the objects, used to calculate, and then update to UI
    private float TotalDamageBossDone;
    private float TotalDamageWarriorDone;
    private float TotalDamageRogueDone;
    private float TotalDamageMageDone;
    private float TotalDamageDruidDone;
    private float TotalPartyDone;
        //Health values, used to calculate, and then update to UI.
    private float Boss_Health;
    private float Warrior_Health;
    private float Rogue_Health;
    private float Mage_Health;
    private float Druid_Health;
    private float Priest_Health;


    public void Start()
    {
        /*
        //bool t = gameObject.name.Equals("healer");
        //Get the Text components from Text objects
        TotalDamageBossDone_text = GameObject.Find("").GetComponent<Text>();
        TotalDamageWarriorDone_text = TotalDamageWarriorDone.GetComponent<Text>();
        TotalDamageRogueDone_text = TotalDamageRogueDone.GetComponent<Text>();
        TotalDamageMageDone_text = TotalDamageMageDone.GetComponent<Text>();
        TotalDamageDruidDone_text = TotalDamageDruidDone.GetComponent<Text>();
        TotalPartyDone_text = TotalPartyDone.GetComponent<Text>();
        */
    }

    void Update()
    {
        //Update demage to the screen.
        TotalDamageBossDone_text.text = "Boss : $" + TotalDamageBossDone.ToString();
        TotalDamageWarriorDone_text.text = "Warrior : $" + TotalDamageWarriorDone.ToString();
        TotalDamageRogueDone_text.text = "Rogue : $" + TotalDamageRogueDone.ToString();
        TotalDamageMageDone_text.text = "Mage : $" + TotalDamageMageDone.ToString();
        TotalDamageDruidDone_text.text = "Druid : $" + TotalDamageDruidDone.ToString();
        TotalPartyDone = TotalPartyDone + TotalDamageWarriorDone + TotalDamageRogueDone + TotalDamageMageDone + TotalDamageDruidDone;
        TotalPartyDone_text.text = "Total Party : $" + TotalPartyDone.ToString();

        //Update heath of each character to ......; (I don't know how the UI uses the health values)
        //Somethings below to update.
    }
    private void LateUpdate()
    {
        
    }

    //Modifier, Whenever a character deals damage, 
    //The character uses a methods from another class, then that class uses the following methods. 
    public void BossDealDamage(float demage)
    {
        TotalDamageBossDone += demage;
    }

    public void WarriorDealDamage(float demage)
    {
        TotalDamageWarriorDone += demage;
    }

    public void RogueDealDamage(float demage)
    {
        TotalDamageRogueDone += demage;
    }

    public void MageDealDamage(float demage)
    {
        TotalDamageMageDone += demage;
    }

    public void DruidDealDamage(float demage)
    {
        TotalDamageDruidDone += demage;
    }

    //Modifier, Get the current health of each one
    //The character uses a methods from another class, then that class uses the following methods. 
    public void BossCurrentHealth(float health) 
    {
        Boss_Health = health;
    }
    public void WarriorCurrentHealth(float health)
    {
        Warrior_Health = health;
    }
    public void RogueCurrentHealth(float health)
    {
        Rogue_Health = health;
    }
    public void MageCurrentHealth(float health)
    {
        Mage_Health = health;
    }
    public void DruidCurrentHealth(float health)
    {
        Druid_Health = health;
    }
    public void PriestCurrentHealth(float health)
    {
        Priest_Health = health;
    }

    public float GetTotalDemegePartyToBoss() 
    {
        return TotalPartyDone;
    }
    public float GetTotalDemageBossToParty()
    {
        return TotalDamageBossDone;
    }

}
