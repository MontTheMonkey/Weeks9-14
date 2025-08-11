using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDraw : MonoBehaviour
{
    LineRenderer lineRndr;
    Vector3 mousePos;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        lineRndr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            lineRndr.positionCount++;
            lineRndr.SetPosition(lineRndr.positionCount - 1, mousePos);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            currentTime += Time.deltaTime;
            if (lineRndr.positionCount != 0 && currentTime > 0.5f)
            {
                lineRndr.positionCount--;
                currentTime = 0;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            currentTime = 0;
        }
    }
}
