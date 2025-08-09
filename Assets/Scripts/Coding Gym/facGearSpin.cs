using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facGearSpin : MonoBehaviour
{
    public float gearSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, gearSpeed * Time.deltaTime);
    }
}
