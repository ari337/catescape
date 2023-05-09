using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //오브젝트에 접근할 수 있는 변수

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하시킨다.
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트를 소멸 시킨다.
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌판정

        Vector2 p1 = transform.position;   //화살의 중심 좌표
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;   //거리 방향
        float d = dir.magnitude; //거리만 가져오는 방법
        float r1 = 0.3f;      //화살의 반경
        float r2 = 0.8f;       //플레이어의 반경

        if(d < r1 + r2)
        {
            //충돌한 경우는 화살을 지운다.
            Destroy (gameObject);
        }

    }
}
