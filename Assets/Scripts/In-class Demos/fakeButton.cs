using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeButton : MonoBehaviour
{
    public float distanceToButton;
    public float distance;
    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            distanceToButton = Vector2.Distance(transform.position, mousePos);
            Debug.Log("Distance is " + distanceToButton);
            if (distanceToButton < distance)
            {
                Debug.Log("meow");
            }
        }
    }
}
