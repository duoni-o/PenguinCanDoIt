using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 스피드 설정
    public float speed = 8;

    private void Update()
    {
        // 오른쪽으로 가도록 함
        transform.position += transform.right * speed * Time.deltaTime;
        Destroy(gameObject, 1f); // 시간이 흐르면(여기선 1초) 사라짐
    }
}
