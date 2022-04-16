using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject heart;

    // Start is called before the first frame update
    void Start()
    {
        this.heart = GameObject.Find("heart");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        // hp 이미지를 특정 비율만큼 없앰
        this.heart.GetComponent<Image>().fillAmount -= 0.34f;
    }
}
