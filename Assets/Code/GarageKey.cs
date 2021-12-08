using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageKey : MonoBehaviour
{
    public GameObject door;
    public GameObject axe;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GarageDoor")
        {
            Destroy(door.gameObject);
            Debug.Log("Contact");
        }

    }
}
