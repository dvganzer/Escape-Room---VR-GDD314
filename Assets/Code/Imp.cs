using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject Crawlers;
    public AudioSource laugh;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Crawlers.SetActive(false);
            laugh.Play();
        }

    }
}

