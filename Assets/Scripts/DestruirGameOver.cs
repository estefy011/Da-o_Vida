using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestruirGameOver : MonoBehaviour
{
    public GameObject gameOverCanvas; // referencia al canvas que se muestra cuando el jugador muere
    public string menuSceneName = "MenuScene"; // el nombre de la escena del menú
    public float delayBeforeMenu = 2.0f; // tiempo de espera antes de cargar el menú, en segundos

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    // Esta función se llama cuando el personaje muere
    public void OnDeath()
    {
        isGameOver = true;
        gameOverCanvas.SetActive(true);  // mostrar el canvas de game over
        StartCoroutine(LoadMenuAfterDelay());
    }

    IEnumerator LoadMenuAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeMenu);
        SceneManager.LoadScene(menuSceneName);
    }

    // Asegúrate de llamar a OnDeath() cuando tu personaje muere
}
