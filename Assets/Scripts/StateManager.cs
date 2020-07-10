using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject Player;

    void Update()
    {
        if (Player == null)
        {
            GameOverCanvas.SetActive(true);
        }
        else
        {
            GameOverCanvas.SetActive(false);
        }
    }
}
