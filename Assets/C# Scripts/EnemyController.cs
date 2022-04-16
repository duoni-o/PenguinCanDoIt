using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // 변수 설정
    int a = 1;

    // Update is called once per frame
    void Update()
    {
        // 특정 위치까지 가게 되면
        if (transform.localPosition.x < -0.2f)
        {
            // 변수 부호 변경
            a = -1;
        }
        else if (transform.localPosition.x > -0.1f)
        {
            a = 1;
        }

        // 위 변수 부호에 따라 Enemy가 움직이는 방향이 달라지게 됨
        transform.Translate(Vector3.left * 4.0f * Time.deltaTime * a);
    }
}
