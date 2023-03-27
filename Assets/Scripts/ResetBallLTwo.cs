using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallLTwo : MonoBehaviour
{
    private Transform Place;

    public void LocatieReset()
    {
        Place = GetComponent<Transform>();
        Place.position = new Vector3(-16f, -1f, 0.0f);
    }
}