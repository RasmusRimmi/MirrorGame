using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHold : MonoBehaviour
{
    public GameObject wallHold;
    // while on top of the button disables the wall
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallHold.SetActive(false);
    }
    // the wall reappers when nothing is on top of the button
    private void OnTriggerExit2D(Collider2D collision)
    {
        wallHold.SetActive(true);
    }
}
