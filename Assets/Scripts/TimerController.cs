using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerController : MonoBehaviour
{
    // asigna esto en el inspector de Unity
    public TextMeshProUGUI timerText;

    [SerializeField] private float timer = 300; // 5 minutos en segundos
    public GameObject Game;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            // actualiza el texto del temporizador
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            // el tiempo se ha acabado, imprime Game Over
            Instantiate(Game);
        }
    }
}
