using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class carMove : MonoBehaviour
{
    public trafficLight trfLightScr;
    public UnityEvent trfEventStates;
    public float carSpeed = 1.5f;
    public float carBounceSpeed = 45f;
    Vector2 carPos;
    bool carBounced = false;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn location
        carPos.x = -11;
        carPos.y = -3;
    }

    // Update is called once per frame
    void Update()
    {
        if (trfLightScr.carMoving == true && carBounced == false)
        {
            carPos.x += carSpeed * Time.deltaTime;
            transform.position = carPos;
        }
        if (carPos.x >= 7.5f || carBounced == true)
        {
            carPos.x -= carBounceSpeed * Time.deltaTime;
            transform.position = carPos;
            carBounced = true;
        }
        if (carPos.x < -11)
        {
            carBounced = false;
        }
    }
}
