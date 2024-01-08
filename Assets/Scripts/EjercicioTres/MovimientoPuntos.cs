using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] listaVectores ;

    public NavMeshAgent agente;

    int actual = 0;

    private void Start()
    {
       /* TODO: Crear la lista de puntos (se puede hacer por código o desde la UI*/
       /* TODO: Establecer el primer punto como destino */

    }

    // Update is called once per frame
    void Update()
    {
       /* El algoritmo es algo así:
        *  1 - Si hemos llegado al destino (es decir, la x y z de mi transform es igual al destino establecido en el agente)
        *  2 - Busco cual es el siguiente punto, y lo establezco como destino. ¿Qué pasa si hemos llegado al último punto?
        */
      
    }
}
