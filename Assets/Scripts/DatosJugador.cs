using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    public Vector3 posicionInicial;
    public int muertes;
     [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    public GameObject Game;
    public GameObject Objetivo;

  

    void Start()
    {
         Instantiate(Objetivo);
        // Cargamos la posicion inicial desde un archivo JSON si existe
        string path = Application.persistentDataPath + "/posicionInicial.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            posicionInicial = JsonUtility.FromJson<Vector3>(json);
        }
        else
        {
            // Guardamos la posicion inicial en un archivo JSON
            posicionInicial = transform.position;
            string json = JsonUtility.ToJson(posicionInicial);
            File.WriteAllText(path, json);
        }

        // Reseteamos la vida y las muertes
        vidaPlayer = 100;
        muertes = 0;
    }

    void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        if (vidaPlayer <= 0)
        {
            muertes++;
            if (muertes < 3)
            {
                // Revivimos al jugador
                vidaPlayer = 100;
                transform.position = posicionInicial;
            }
            else
            {
                // Terminamos el juego
                 Instantiate(Game);
                // Aquí podrías poner un código para terminar el juego
            }
        }
    }
       private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Animal"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(other.gameObject);
        }
        

    }
}




