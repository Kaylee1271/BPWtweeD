using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private Transform locatie;

    public void LocatieReset()
    {
        locatie = GetComponent<Transform>();
        locatie.position= new Vector3(-29.37f, 4.66f, 0.0f);    
    }
}
