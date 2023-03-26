using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHold : MonoBehaviour
{
    public GameObject wallHold;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallHold.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wallHold.SetActive(true);
    }
}
