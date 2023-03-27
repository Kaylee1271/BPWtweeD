using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerDrawSprite : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile tileDrawPlayer;
    public Vector3Int location;
    public Vector3Int locationR;

    //tekenen maar moet gelinkt zijn 
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tilemap.WorldToCell(mousepress);
            if (tilemap.GetTile(location + new Vector3Int(0, 1, 0)) || tilemap.GetTile(location) || tilemap.GetTile(location + new Vector3Int(1, 0, 0)) || tilemap.GetTile(location + new Vector3Int(-1, 0, 0)) || tilemap.GetTile(location + new Vector3Int(0, -1, 0)))
            {
                tilemap.SetTile(location, tileDrawPlayer);
            }
            else
            {
                Debug.Log("Geen Aanhechtingspunt");
            }

    //niet mogenlijk in combinatie met GetMouseButton
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Los");
                Vector3 mouserelease = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                location = tilemap.WorldToCell(mouserelease);
                if (location == new Vector3Int(1, 5, 0) || location == new Vector3Int(15, 5, 0))
                {
                    Debug.Log("Los In Range");
                }
            }
        }
        //Rechts klikken om te verwijderen
        if (Input.GetMouseButton(1))
        {
            Vector3 Rmousepress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            locationR = tilemap.WorldToCell(Rmousepress);
            if (tilemap.GetTile(locationR))
            {
                tilemap.SetTile(locationR, null);
            }
        }
    }
}

//1,5) (15,5
//startlocaties zijn te verweideren waardoor er geen aanhechtingspunt meer is.