using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Cinemachine;

public class tileSwapper : MonoBehaviour
{
    public Tilemap gameTilemap;
    public Tile grassTile;
    public Tile rockTile;
    Vector2 mousePos;
    Vector3Int tilePosition;
    public CinemachineImpulseSource cameraImpulseSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tilePosition = gameTilemap.WorldToCell(mousePos);
            Debug.Log("Tile position selected is: " + tilePosition);

            Tile selectedTile = (Tile)gameTilemap.GetTile(tilePosition);

            if (selectedTile != rockTile)
            {
                gameTilemap.SetTile(tilePosition, rockTile);
                cameraImpulseSource.GenerateImpulse();
            }
            else
            {
                gameTilemap.SetTile(tilePosition, grassTile);
            }
        }
    }
}
