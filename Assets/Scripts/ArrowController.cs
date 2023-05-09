using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //������Ʈ�� ������ �� �ִ� ����

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ӹ��� ������� ���Ͻ�Ų��.
        transform.Translate(0, -0.1f, 0);

        //ȭ�� ������ ������ ������Ʈ�� �Ҹ� ��Ų��.
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹����

        Vector2 p1 = transform.position;   //ȭ���� �߽� ��ǥ
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;   //�Ÿ� ����
        float d = dir.magnitude; //�Ÿ��� �������� ���
        float r1 = 0.3f;      //ȭ���� �ݰ�
        float r2 = 0.8f;       //�÷��̾��� �ݰ�

        if(d < r1 + r2)
        {
            //�浹�� ���� ȭ���� �����.
            Destroy (gameObject);
        }

    }
}
