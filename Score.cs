using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Used to update the Text in Score Scene.
public class Score : MonoBehaviour
{
    //Get the score from here, Drag the Manager inside.
    public Manager M;

    //Drag the Text objects in
    public Text totalDemegePartyToBoss_Level1;
    public Text totalDemageBossToParty_Level1;

    public Text totalDemegePartyToBoss_Level2;
    public Text totalDemageBossToParty_Level2;

    public Text totalDemegePartyToBoss_Level3;
    public Text totalDemageBossToParty_Level3;

    void Start()
    {
        //Update the Text component in Text objects;
        totalDemegePartyToBoss_Level1.text = "Party To Boss Level1 : " + M.getP2B1().ToString();
        totalDemageBossToParty_Level1.text = "Boss To Party Level1 : " + M.getB2P1().ToString();

        totalDemegePartyToBoss_Level2.text = "Party To Boss Level2 : " + M.getP2B2().ToString();
        totalDemageBossToParty_Level2.text = "Boss To Party Level2 : " + M.getB2P2().ToString();

        totalDemegePartyToBoss_Level3.text = "Party To Boss Level3 : " + M.getP2B3().ToString();
        totalDemageBossToParty_Level3.text = "Boss To Party Level3 : " + M.getB2P3().ToString();
    }

}
