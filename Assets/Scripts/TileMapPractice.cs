using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class TileMapPractice : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile tileDrawPlayer;
    public Tile tileDrawGame;
    public Vector3Int location;
    public Vector3Int randomLocatie;
    float timePassed = 0f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //locatie muis press opgeslagen in vector3 mousepress
            Vector3 mousepress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // ?
            location = tilemap.WorldToCell(mousepress);
            //tile activeren op plaats van tile en muis positie
            tilemap.SetTile(location, tileDrawPlayer);
;        }

        if (Input.GetMouseButton(1))
        {
            GetT();
        }



        timePassed += Time.deltaTime;
        if (timePassed > 5f)
        {
            //met intervallen van "TimepPassed" word er een random tile geplaatst
            int RandX = Random.Range(0, 28);
            int RandY = Random.Range(0, 16);

            randomLocatie = new Vector3Int(RandX, RandY, 0);
            tilemap.SetTile(randomLocatie, tileDrawGame);
            timePassed = 0;
        }
    }
    //Herkent tiles zowel van de player als de comuter
    void GetT()
    {
        Vector3 mousepress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        location = tilemap.WorldToCell(mousepress);
        if (tilemap.GetTile(location))
        {
            Debug.Log("Tile");
        }
        else
        {
            Debug.Log("No Tile");
        }
    }


}


//toevoegen wanneer er door de player een tile is geplaatst kan de game daar geen tile overheen plaatsen, locatie kunnen vinden true or false.
//Maximum aantal tiles voor de speler.
//Max tiles dinamisch aan de afstand van game tiles.