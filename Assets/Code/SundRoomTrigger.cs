using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundRoomTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject Crawlers;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Crawlers.SetActive(true);
        }

    }
}
