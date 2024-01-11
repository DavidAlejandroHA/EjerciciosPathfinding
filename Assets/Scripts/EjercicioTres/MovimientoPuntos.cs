using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] listaVectores;
    public NavMeshAgent agente;
    int mascara = 1 << 6;
    //Transform destino;
    public int actual =0;

    private void Start()
    {
        /* TODO: Crear la lista de puntos (se puede hacer por código o desde la UI*/
        /* TODO: Establecer el primer punto como destino */
        agente = GetComponent<NavMeshAgent>();
        agente.destination = listaVectores[actual];
        
        /*Debug.Log(transform.position.x);
        Debug.Log(listaVectores[0]);
        Debug.Log(agente);*/
    }

    // Update is called once per frame
    void Update()
    {
        /* El algoritmo es algo así:
         *  1 - Si hemos llegado al destino (es decir, la x y z de mi transform es igual al destino establecido en el agente)
         *  2 - Busco cual es el siguiente punto, y lo establezco como destino. ¿Qué pasa si hemos llegado al último punto?
         */
        //Debug.Log(transform.position.x == listaVectores[actual].x && transform.position.z == listaVectores[actual].z);
        if (transform.position.x == agente.destination.x && transform.position.z == agente.destination.z)
        {
            Debug.Log("actual antes " + actual);
            actual++;
           
            if (actual == listaVectores.Length)
            {
                actual = 0;
                //agente.destination = listaVectores[actual];
                Debug.Log("REINICIO");
            }
            else
            {

            }
            Debug.Log("actual despues " + actual);
            agente.destination = listaVectores[actual];
        }

        RaycastHit golpe;
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;
        if (Physics.Raycast(origen, direccion, out golpe, 3f, mascara))
        {
            //Debug.Log(golpe.collider.gameObject.name);
            //Destroy(golpe.collider.gameObject);
            Debug.Log("algo");
            agente.destination = golpe.point;
        }
        else
        {
            //agente.destination = listaVectores[actual];
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.forward);
    }
}
