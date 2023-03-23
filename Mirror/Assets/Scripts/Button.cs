using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject wall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.SetActive(false);

        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wall.SetActive(true);

        transform.position = new Vector3(transform.position.x, 0.56f, transform.position.z);
    }
}
