using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject door;
    public GameObject doors;
    public static int score;
    public AudioSource dooropen;
    // Update is called once per frame
    void Update()
    {
        if (score == 3)
        {
            Destroy(door);
            Destroy(doors);
            dooropen.Play();
        }
    }
}
