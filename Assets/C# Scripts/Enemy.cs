using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Penguin과 닿게 되면
        if (collision.gameObject.name.Contains("Penguin"))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp(); // DecreaseHP 함수 호출
            GameObject heart = GameObject.Find("heart"); // 체력 이미지 찾기
        }
        // Bullet과 닿게 되면
        else if (collision.gameObject.name.Contains("Bullet"))
        {
            // Enemy 파괴
            Destroy(this.gameObject);
        }

        //Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
