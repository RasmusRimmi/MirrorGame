using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject wallPress;
    // this button only needs to be pressed once and the wall stays gone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallPress.SetActive(false);
    }
}
