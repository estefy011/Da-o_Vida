using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DatosJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaPlayer;
    public Slider vidaVisual;

    // Update is called once per frame
    void Update()
    {

        vidaVisual.GetComponent<Slider>().value=vidaPlayer;
        if(vidaPlayer <=0)

        {
        Debug.Log("Game");
        }
        
    }
}


