using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public GameObject powerUp;
    public Player1Controller player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
