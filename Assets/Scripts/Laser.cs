using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, 0.4f);
    }
}
