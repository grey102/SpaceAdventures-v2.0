using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
