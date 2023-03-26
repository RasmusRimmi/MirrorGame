using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public float timeToTogglePlatform = 2;
    public float currentTime = 0;
    public new bool enabled = true;
    void Start()
    {
        enabled = true;
        currentTime = 2;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToTogglePlatform)
        {
            currentTime = 0;
            TogglePlatform();
        }
    }
    void TogglePlatform()
    {
        enabled = !enabled;
        foreach(Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(enabled);
        }
    }
}
