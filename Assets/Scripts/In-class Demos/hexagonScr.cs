using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hexagonScr : MonoBehaviour
{
    SpriteRenderer hexaRndr;
    public UnityEvent onColourChange;
    public float colourChangedValue;
    // Start is called before the first frame update
    void Start()
    {
        hexaRndr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickColour()
    {
        hexaRndr.color = Random.ColorHSV();
        onColourChange.Invoke();
    }
}
