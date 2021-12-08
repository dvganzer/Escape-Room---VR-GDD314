using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    public GameObject axe;
    public AudioSource open;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BasementDoor")
        {
            open.Play();
            Destroy(door.gameObject);

        }
        
    }
}
