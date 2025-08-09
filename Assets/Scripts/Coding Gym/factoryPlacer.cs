using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class factoryPlacer : MonoBehaviour
{
    public GameObject facPrefab;
    public List<GameObject> factoryList = new List<GameObject>();
    GameObject currentFactory;
    Vector2 mousePos;
    int i = 0;
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
            currentFactory = Instantiate(facPrefab, mousePos, quaternion.identity);
            factoryList.Add(currentFactory);
        }
    }
}
