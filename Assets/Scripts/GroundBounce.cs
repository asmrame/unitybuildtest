using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBounce : MonoBehaviour
{
    public Vector2 changeOnBounce;

    void OnCollisionEnter2D(Collision2D col)
    {
        transform.Translate(changeOnBounce);
    }
}
