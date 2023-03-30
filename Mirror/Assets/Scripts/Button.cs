using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject wall;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        wall.SetActive(false);
        anim.Play("ButtonDown_Animation");

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
        wall.SetActive(true);
        anim.Play("ButtonUp_Animation");
    }
}
