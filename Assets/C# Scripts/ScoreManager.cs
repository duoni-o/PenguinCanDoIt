using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    // Start is called before the first frame update
    public int score;
    public Text textScore;

    public void AddScore()
    {
        // 점수 10점씩 증가
        score += 10;
        // 증가한 점수 표시
        textScore.text = score.ToString();
    }
    void Start()
    {
        // 텍스트에 점수 표시하도록 함. 처음엔 설정해둔 점수(0점)
        textScore.text = score.ToString();
    }
}
