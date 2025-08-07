using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class trafficLight : MonoBehaviour
{
    public GameObject trfGoLight;
    public GameObject trfStopLight;
    public bool carMoving;
    // Start is called before the first frame update
    void Start()
    {
        trfGoLight.SetActive(false);
        trfStopLight.SetActive(false);
        carMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            onStopLight();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            onGoLight();
        }
    }

    public void onStopLight()
    {
        trfGoLight.SetActive(false);
        trfStopLight.SetActive(true);
        carMoving = false;
    }
    public void onGoLight()
    {
        trfGoLight.SetActive(true);
        trfStopLight.SetActive(false);
        carMoving = true;
    }
}
