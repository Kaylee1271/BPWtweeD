using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private Rigidbody2D body;
    private Transform locatie;

    public void LocatieReset()
    {
        locatie = GetComponent<Transform>();
        locatie.position= new Vector3(-29.37f, 4.66f, 0.0f);
        body = GetComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Static;
    }
}
