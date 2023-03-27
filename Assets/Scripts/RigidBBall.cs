using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBBall : MonoBehaviour
{
    private Rigidbody2D body;

    public void BallRoll ()
    {
        body = GetComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Dynamic;
    }
}
