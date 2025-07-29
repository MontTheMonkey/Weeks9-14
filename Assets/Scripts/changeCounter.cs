using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changeCounter : MonoBehaviour
{
    TMP_Text changeColourTMP;
    hexagonScr hexagon;
    public Button hexColButton;
    int changeCounterInt;
    // Start is called before the first frame update
    void Start()
    {
        changeColourTMP = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void counterIncrease()
    {
        changeCounterInt++;
        changeColourTMP.text = "Colour changed: " + changeCounterInt;
    }
}
