using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallTur : MonoBehaviour
{
    private Transform locatie;

    public void LocatieReset()
    {
        locatie = GetComponent<Transform>();
        locatie.position = new Vector3(-28.67f, 1.91f, 0.0f);
    }
}
