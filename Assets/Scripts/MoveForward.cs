using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
