using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject axe;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BedRoomDoor")
        {
            Destroy(door.gameObject);
            Debug.Log("Contact");
        }
        
    }
}
