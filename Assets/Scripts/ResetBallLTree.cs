using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallLTree : MonoBehaviour
{
    private Transform locatie;

    public void LocatieReset()
    {
        locatie = GetComponent<Transform>();
        locatie.position = new Vector3(-28.16f, 1.12f, 0.0f);
    }
}

