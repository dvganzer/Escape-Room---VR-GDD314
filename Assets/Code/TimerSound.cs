using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSound : MonoBehaviour
{
    public AudioSource growl;
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int seconds = (int)timer;

        if (seconds == 15)
        {
            growl.Play();
            timer = 0f;
        }
    }
}
