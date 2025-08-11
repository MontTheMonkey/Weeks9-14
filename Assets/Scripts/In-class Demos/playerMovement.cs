using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Vector2 playerPos;
    float playerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerPos.y += playerSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= playerSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += playerSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= playerSpeed * Time.deltaTime;
            transform.position = playerPos;
        }
    }
}
