using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitle : MonoBehaviour
{
    public void LoadScene()
    {
        // 시작 화면으로 전환
        SceneManager.LoadScene("TitleScene");
    }
}
