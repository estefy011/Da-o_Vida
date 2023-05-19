using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen= pantallaCompleta;
        
    }


public void ControlVolumen(float volumen)
{
    audioMixer.SetFloat("Volumen", volumen);


}
  
}
