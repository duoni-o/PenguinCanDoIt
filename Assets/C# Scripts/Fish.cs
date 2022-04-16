using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Penguin과 닿게 되면
        if (collision.gameObject.name.Contains("Penguin"))
        {
            // 씬 전환
            SceneManager.LoadScene("GameScene2");
        }
    }
}
