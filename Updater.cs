using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
{

    //Storing the Text objects. Drag the Text objects in.
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


    void Update()
    {
        //Update demage to the screen.
        TotalDamageBossDone_text.text = "Boss : " + TotalDamageBossDone.ToString();
        TotalDamageWarriorDone_text.text = "Warrior : " + TotalDamageWarriorDone.ToString();
        TotalDamageRogueDone_text.text = "Rogue : " + TotalDamageRogueDone.ToString();
        TotalDamageMageDone_text.text = "Mage : " + TotalDamageMageDone.ToString();
        TotalDamageDruidDone_text.text = "Druid : " + TotalDamageDruidDone.ToString();
        TotalPartyDone = TotalPartyDone + TotalDamageWarriorDone + TotalDamageRogueDone + TotalDamageMageDone + TotalDamageDruidDone;
        TotalPartyDone_text.text = "Total Party : " + TotalPartyDone.ToString();

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
