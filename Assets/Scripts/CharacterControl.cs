using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.position += new Vector3(0.1f, 0f, 0f);
        }


        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.position -= new Vector3(0.1f, 0f, 0f);
        }


        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.position += new Vector3(0f, 0f, 0.1f);
        }


        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.position -= new Vector3(0f, 0f, 0.1f);
        }

    }
}
