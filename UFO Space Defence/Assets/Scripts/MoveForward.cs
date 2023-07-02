using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 50.0f;//speed at which this object moves forward

    void Update()
    {
        //Move projectile forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
