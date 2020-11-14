using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 2; 
    public Transform[] target;  
    public float delta = 0.2f; 
    private static int i = 0;

    void Update()
    {
        moveTo();
    }

    void moveTo()
    {
        target[i].position = new Vector3(target[i].position.x, transform.position.y, target[i].position.z);
        transform.LookAt(target[i]);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x > target[i].position.x - delta
            && transform.position.x < target[i].position.x + delta
            && transform.position.z > target[i].position.z - delta
            && transform.position.z < target[i].position.z + delta)
            i = (i + 1) % target.Length;
    }
}