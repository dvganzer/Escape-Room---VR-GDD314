using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : MonoBehaviour
{
    public Transform crawler;
    public GameObject C;


    // Update is called once per frame
    void Update()
    {
    
        
            crawler.position += Vector3.left * .05f;
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
       C.SetActive(false);
    }



}
