using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : MonoBehaviour
{
    public Transform player; // referencia al jugador
    public float followSpeed = 3f; // velocidad a la que sigue al jugador
    public float followDistance = 2f; // distancia a la que sigue al jugador

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        // Calcula la dirección hacia el jugador
        Vector3 direction = (player.position - transform.position).normalized;

        // Define la posición objetivo a la que el seguidor debería dirigirse, que es la posición del jugador menos la distancia de seguimiento en la dirección del jugador.
        Vector3 targetPosition = player.position - direction * followDistance;

        // Sigue al jugador si no está ya en la misma posición
        if (Vector3.Distance(targetPosition, transform.position) > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, followSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.15f);
        }
    }
}
