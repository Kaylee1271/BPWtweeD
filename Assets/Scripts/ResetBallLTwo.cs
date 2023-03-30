using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallLTwo : MonoBehaviour
{
    private Rigidbody2D body;
    private Transform Place;

    public void LocatieReset()
    {
        Place = GetComponent<Transform>();
        Place.position = new Vector3(-16f, -1f, 0.0f);
        body = GetComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Static;
    }
}