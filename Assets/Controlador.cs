using UnityEngine;

public class Controlador : MonoBehaviour
{
     // Velocidades configurables desde el Inspector
    public float velocidadMovimiento = 5.0f;
    public float velocidadGiro = 200.0f;

    // Referencia al CharacterController
    private CharacterController controlador;

    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Obtener valores de entrada
        float movimientoAdelanteAtras = Input.GetAxis("Vertical");
        float giroIzquierdaDerecha = Input.GetAxis("Horizontal");

        // Calcular el giro
        transform.Rotate(0, giroIzquierdaDerecha * velocidadGiro * Time.deltaTime, 0);

        // Calcular el movimiento
        Vector3 movimiento = transform.TransformDirection(Vector3.forward) * movimientoAdelanteAtras * velocidadMovimiento * Time.deltaTime;

        // Aplicar el movimiento al CharacterController
        controlador.Move(movimiento);
    }
}
