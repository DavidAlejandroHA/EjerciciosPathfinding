using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Hay que incluir esta dependencia!
using UnityEngine.AI;

public class MovimientoAgente : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destino;
    public Vector3 origen;
    Vector3 vectorFinal = new Vector3(0f, 0f, 0f);
    void Start()
    {
        /* TODO: Obtener una referencia al agente, y establecer como destino las coordenadas del objeto 'Premio' */
        agent = GetComponent<NavMeshAgent>();
        agent.destination = destino.position;
        origen = transform.position;
    }
    //Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
    //RaycastHit golpeRayo;

    // ¿Hace falta poner el Update?
    void Update()
    {
        // si mi posicion en el eje x y z es igual a la del destino...
        // modificamos el agente para que el destino nuevo sea el punto inicial.
        //Debug.Log(transform.position);
        //Debug.Log(Vector3.Distance(transform.position,destino.position));

        //if (Vector3.Distance(transform.position, destino.position) < 1)
        if (transform.position.x == destino.position.x && transform.position.z == destino.position.z)
        {
            agent.destination = origen;
        }
    }


}
