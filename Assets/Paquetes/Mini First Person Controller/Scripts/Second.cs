using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField]
    Transform character;
    [SerializeField]
    Transform cameraTransform;
    public float sensitivity = 2;
    public float smoothing = 1.5f;

    Vector2 velocity;
    Vector2 frameVelocity;


    void Reset()
    {
        // Obtén el personaje del componente FirstPersonMovement en los padres.
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }

    void Start()
    {
        // Bloquea el cursor del mouse en la pantalla del juego.
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Obtén la velocidad suavizada.
        Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Rota la cámara hacia arriba-abajo y el personaje hacia la izquierda-derecha según la velocidad.
        cameraTransform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}
