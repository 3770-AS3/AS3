using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalScore : MonoBehaviour
{
    public static GlobalScore instance;

    private float totalDemegePartyToBoss_Level1;
    private float totalDemageBossToParty_Level1;

    private float totalDemegePartyToBoss_Level2;
    private float totalDemageBossToParty_Level2;

    private float totalDemegePartyToBoss_Level3;
    private float totalDemageBossToParty_Level3;

    //The following Awake() is to ensure that there is only one piece of data when switching between scenes.
    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this) 
        {
            Destroy(gameObject);
        }
    }

    //Update to corresponding level if the new record is greater

    public void CheckAndUpdateScoreClass(float totalP2B, float totalB2P) 
    {
        //Find the current Scene
        if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            //Check if it is greater for both value of a level
            if (totalP2B > totalDemegePartyToBoss_Level1) 
            {
                totalDemegePartyToBoss_Level1 = totalP2B;
            }
            if (totalB2P > totalDemageBossToParty_Level1) 
            {
                totalDemageBossToParty_Level1 = totalB2P;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            if (totalP2B > totalDemegePartyToBoss_Level2)
            {
                totalDemegePartyToBoss_Level2 = totalP2B;
            }
            if (totalB2P > totalDemageBossToParty_Level2)
            {
                totalDemageBossToParty_Level2 = totalB2P;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            if (totalP2B > totalDemegePartyToBoss_Level3)
            {
                totalDemegePartyToBoss_Level3 = totalP2B;
            }
            if (totalB2P > totalDemageBossToParty_Level3)
            {
                totalDemageBossToParty_Level3 = totalB2P;
            }
        }
        else 
        {
            Debug.Log("Cannot match the scene");
        }
        
    }

    //Get every Score
    public float GetP2B1() 
    {
        return totalDemegePartyToBoss_Level1;
    }
    public float GetP2B2()
    {
        return totalDemegePartyToBoss_Level2;
    }
    public float GetP2B3()
    {
        return totalDemegePartyToBoss_Level3;
    }
    public float GetB2P1()
    {
        return totalDemageBossToParty_Level1;
    }
    public float GetB2P2()
    {
        return totalDemageBossToParty_Level2;
    }
    public float GetB2P3()
    {
        return totalDemageBossToParty_Level3;
    }

}
