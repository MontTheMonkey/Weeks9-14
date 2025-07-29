using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagonSpawner : MonoBehaviour
{
    public GameObject hexObj;
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
        spawnPos = (Vector2)transform.position + Random.insideUnitCircle * 5;
        Instantiate(hexObj, spawnPos, Quaternion.identity);
    }
}
