using UnityEngine;

public class MeteoritMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -0.05f);
    }
}