using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ComportamientoCamara : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject agenteObjeto;
    //public Vector3 origen;
    void Start()
    {
        /* TODO: Obtener una referencia al agente, y establecer como destino las coordenadas del objeto 'Premio' */
        agent = agenteObjeto.GetComponent<NavMeshAgent>();
        //agent.destination = destino.position;
        //origen = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /* TODO: Lanzar un rayo al pulsar el botón, y modificar el destino de nuestro agente */
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpeRayo;
            if (Physics.Raycast(rayo, out golpeRayo, 100000f))
            {
                agent.destination = golpeRayo.point;
            }
        }
        
    }

}
