using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Plus One Point");
    }
}
