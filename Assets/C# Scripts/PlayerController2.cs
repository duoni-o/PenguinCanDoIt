using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하는 데 필요하다.

public class PlayerController2 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float walkForce = 50.0f;
    float maxWalkSpeed = 3.0f;
    int jumpCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프한다.(2단까지 가능)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300f);
                jumpCount++;
            }
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어의 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // 움직이는 방향에 따라 반전한다.
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 플레이어 속도에 맞춰 애니메이션 속도를 바꾼다.
        this.animator.speed = speedx / 2.0f;

        // 플레이어가 화면 밖으로 나갔다면 처음부터
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
    }

    // 골 도착
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골");
        SceneManager.LoadScene("GameScene3");
    }
}
