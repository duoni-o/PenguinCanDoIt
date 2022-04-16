using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void LoadScene()
    {
        // 게임 씬으로 전환
        SceneManager.LoadScene("GameScene");
    }
}
