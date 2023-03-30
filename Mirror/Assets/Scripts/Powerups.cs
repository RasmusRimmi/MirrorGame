using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public GameObject powerUp;
    public Player1Controller player1;
    public Player2Controller player2;

    private Vector2 normalScale = new Vector2(1.0f, 1.0f);
    private Vector2 bigScale = new Vector2(2.0f, 2.0f);
    private Vector2 smallScale = new Vector2(0.5f, 0.5f);

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

            player1.jumpingPower = 14f;
            player2.jumpingPower = 14f;
            
        }

        if (gameObject.CompareTag("Disable"))
        {
            powerUp.SetActive(false);

            player1.jumpingPower = 10f;

            player1.transform.localScale = normalScale;

        }

        if (gameObject.CompareTag("Bob"))
        {
            powerUp.SetActive(false);

            player1.transform.localScale = bigScale;

            player1.rb.mass = 30f;
        }

        if (gameObject.CompareTag("Bib"))
        {
            powerUp.SetActive(false);

            player1.transform.localScale = smallScale;
        }

    }
}
