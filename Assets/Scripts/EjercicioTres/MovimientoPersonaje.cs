using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movX, movZ;
    Rigidbody fisicas;
    public float speed = 10f;
    bool estaEnSuelo = false;
    bool quiereSaltar = false;
    //int mascara = 1 << 6;
    int mascaraSuelo = 1 << 7;
    //public static bool pausado = false;
    //public static bool finalPartida = false;
    //float segundos = 0f;
    //public float radioRaycast = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        // Detectar cuando el personaje está en el suelo usando el RaycastHit
        RaycastHit hit;
        Vector3 origen = transform.position;
        // Raycast salto
        if (Physics.Raycast(origen, Vector3.down, out hit, 0.51f, mascaraSuelo))
        {
            estaEnSuelo = true;
            //Debug.Log(estaEnSuelo);
        }
        else
        {
            estaEnSuelo = false;
            //Debug.Log(estaEnSuelo);
        }
    }

    private void FixedUpdate()
    {

        // Si está intentando saltar y está en el suelo se pone saltando
        // Raycast salto
        if (Input.GetButton("Jump") /*Input.GetButtonDown*/)
        {
            if (estaEnSuelo)
            {
                quiereSaltar = true;
                Debug.Log(quiereSaltar);
            }
        }

        //Vector3 nuevaVelocidad = new Vector3(movX * speed, fisicas.velocity.y, movZ * speed);
        //fisicas.velocity = nuevaVelocidad;

        // Se añaden constantemente las físicas respecto a los movimientos del teclado
        fisicas.AddForce(movX * speed, 0, movZ * speed, ForceMode.Force);


        // Y se hace saltar al personaje si se cumplen las condiciones
        if (estaEnSuelo && quiereSaltar)
        {
            estaEnSuelo = false;
            quiereSaltar = false;
            fisicas.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
