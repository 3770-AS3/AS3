using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 2; //[1] �����ƶ��ٶ�
    public Transform[] target;  // [2] Ŀ��
    public float delta = 0.2f; // ���ֵ
    private static int i = 0;

    void Update()
    {
        moveTo();
    }

    void moveTo()
    {
        // [3] ���³�ʼ��Ŀ���
        target[i].position = new Vector3(target[i].position.x, transform.position.y, target[i].position.z);

        // [4] �����峯��Ŀ��� 
        transform.LookAt(target[i]);

        // [5] ������ǰ�ƶ�
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // [6] �ж������Ƿ񵽴�Ŀ���
        if (transform.position.x > target[i].position.x - delta
            && transform.position.x < target[i].position.x + delta
            && transform.position.z > target[i].position.z - delta
            && transform.position.z < target[i].position.z + delta)
            i = (i + 1) % target.Length;
    }
}