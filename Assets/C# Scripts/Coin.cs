using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Penguin과 닿게 되면
        if (collision.gameObject.name.Contains("Penguin"))
        {
            // 코인 획득 시 코인 없앰
            Destroy(gameObject);
        
            GameObject scoreManager = GameObject.Find("ScoreManager");
            // AddScore 함수 호출
            scoreManager.GetComponent<ScoreManager>().AddScore();
        }
    }
}
