using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject Susto;

    private void OnTriggerEnter(Collider other) {
        
        if(other.CompareTag("Player"))
        {
            Instantiate(Susto);
        }
    }
}
