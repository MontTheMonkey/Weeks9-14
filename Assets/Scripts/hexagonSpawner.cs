using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class hexagonSpawner : MonoBehaviour
{
    public changeCounter changeCounter;
    public hexagonScr hexagon;
    public GameObject hexObj;
    public Button hexColButton;
    float spawnRadius = 3;
    Vector2 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSpawnClick()
    {
        spawnPos = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
        GameObject spawnedHexObj = Instantiate(hexObj, spawnPos, Quaternion.identity);
        hexagon = spawnedHexObj.GetComponent<hexagonScr>();
        hexColButton.onClick.AddListener(hexagon.onClickColour);
        hexagon.onColourChange.AddListener(changeCounter.counterIncrease);
    }
}
