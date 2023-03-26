using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject wallPress;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallPress.SetActive(false);
    }
}
