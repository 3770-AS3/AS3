using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class att : MonoBehaviour
{
    public GameObject T;
    public int dps=10;

    void attecktarget()
    {
        T.GetComponent<Heath>().TakeDamage(dps);
        Debug.Log("make "+dps+" to "+T.name);

    }

    void Start()
    {
        
    }

    void Update()
    {
        var aa = T;
        var bb = gameObject;
        
      var dis = Vector3.Distance(aa.transform.position, bb.transform.position);
         if (dis < 1.0)
        { 
            attecktarget(); 
        }
           
    }
}
