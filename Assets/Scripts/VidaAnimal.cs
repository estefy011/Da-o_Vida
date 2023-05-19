using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaAnimal : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida;
  public GameObject Player; 

  private void OnTriggerEnter(Collider other) {
    
    if(other.tag == "Player")
    {
        Player.GetComponent<DatosJugador>().vidaPlayer += vida;

    }

     if(other.tag == "Animal")
    {
        Debug.Log("Esto es un animal");

    }
    }
   
}
