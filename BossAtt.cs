using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtt : MonoBehaviour
{
    public GameObject T;
    public int dps = 10;
    public float totaldmg;
    void attecktarget()
    {
        totaldmg = totaldmg +dps;
        private float adddmg = (totaldmg / 100);
        totaldmg = totaldmg + adddmg;
        Debug.Log("make " + dps + " to " + T.name);
        T.GetComponent<Heath>().TakeDamage(dps);
        T.GetComponent<Heath>().TakeDamage(adddmg);

    }
    // Start is called before the first frame update
    void Start()
    {
        T = GameObject.Find("Tank");
        totaldmg = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
