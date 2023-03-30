using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject wall;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();   
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.SetActive(false);
        anim.Play("ButtonPress_Animation");
    }
}
