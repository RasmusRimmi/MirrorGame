using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject wall;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.SetActive(false);
    }
}
