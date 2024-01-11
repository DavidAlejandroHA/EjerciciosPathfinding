using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPresa : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform depredador;
    float magnitud = 1f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, depredador.position)<2)
        {
            agent.destination = transform.position + ((transform.position - depredador.position) * magnitud);
        }
        else
        {
            agent.ResetPath();
        }
    }
}
