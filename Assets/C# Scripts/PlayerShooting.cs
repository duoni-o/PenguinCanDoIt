using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform shootingPosition;
    public GameObject bulletFactory;

    // Update is called once per frame
    void Update()
    {
        // X 버튼을 누르면
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = shootingPosition.position; // 위치를 총구 위치로 옮김
            bullet.transform.rotation = transform.rotation;
        }
    }
}
