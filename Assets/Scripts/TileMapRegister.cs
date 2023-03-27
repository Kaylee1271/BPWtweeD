using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapRegister : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile tileDrawPlayer;
    public Tile tileDrawGame;
    public Vector3Int location;
    public Vector3Int randomLocatie;
    private int Failcounter = 0;
    float timePassed = 0f;
    void Update()
    {
        if (Failcounter <= 99)
        {
            timePassed += Time.deltaTime;
        }
        Failcounter = 0;
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tilemap.WorldToCell(mousepress);
            if (tilemap.GetTile(location))
            {
                Debug.Log("Tile");
            }
            else
            {
                tilemap.SetTile(location, tileDrawPlayer);
            }
        }



        if (timePassed > 5f)
        {
            do
            {
                int RandX = Random.Range(0, 28);
                int RandY = Random.Range(0, 16);
                randomLocatie = new Vector3Int(RandX, RandY, 0);
                Failcounter = Failcounter + 1;
            } while (tilemap.GetTile(randomLocatie) && Failcounter < 200);
            timePassed = 0f;
            if (Failcounter <= 199)
            {
                tilemap.SetTile(randomLocatie, tileDrawGame);
            }
        }
    }
}

//toevoegen wanneer er door de player een tile is geplaatst kan de game daar geen tile overheen plaatsen, locatie kunnen vinden true or false. (DONE)
//Tiles kunnen verwijderen.
//Maximum aantal tiles voor de speler.
//Max tiles dinamisch aan de afstand van game tiles.