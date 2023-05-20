using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosR : MonoBehaviour
{

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    // Start is called before the first frame update
     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Animal"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(other.gameObject);
        }
        

    }
}
