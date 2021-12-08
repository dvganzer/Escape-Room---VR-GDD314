using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerFalse : MonoBehaviour
{
    public GameObject Crawler;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Crawler")
        {
            Crawler.SetActive(false);
        }
    }
}
