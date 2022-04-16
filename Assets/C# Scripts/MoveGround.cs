using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public SpriteRenderer[] ice;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < ice.Length; i++)
        {
            // 이미지를 오->왼으로 움직임
            ice[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
        }
    }
}
