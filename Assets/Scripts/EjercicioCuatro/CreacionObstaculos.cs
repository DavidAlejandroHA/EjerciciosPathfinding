using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class CreacionObstaculos : MonoBehaviour
{
    public NavMeshSurface superficie;
    public GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /* TODO: Lanzar un rayo, e instanciar un obstáculo en el punto donde se golpee */
            /* Hay que reconstruir la superficie, busca un método que se encargue de ello */
            

        }
    }
       
}
