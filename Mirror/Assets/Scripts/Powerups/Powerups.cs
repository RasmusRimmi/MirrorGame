using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public GameObject powerUp;
    public Player1Controller player1;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (gameObject.CompareTag("Jump"))
        {
            powerUp.SetActive(false);

            player1.jumpingPower = 15f;
        }

        if (gameObject.CompareTag("Disable"))
        {
            powerUp.SetActive(false);

            player1.jumpingPower = 10f;
        }
              
    }
}
