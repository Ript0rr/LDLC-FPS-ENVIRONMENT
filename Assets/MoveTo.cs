using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class MoveTo : MonoBehaviour
{
    public bool activated;
    public bool bateau;
    public Transform goal;
    public NavMeshAgent agent;
    public Transform goal_end;
    
    public Transform[] destinations;
    int currentIndex;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();


    }

    void Update()
    {

        //Quand on fait clique gauche
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Lancer un rayon dans la direction de la caméra
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            //Action du rayon
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject == this.gameObject)
                {
                    activated = true;
                    FindObjectOfType<CollectAnimals>().AddAnimal(this);
                }
            }
        }
        if (activated)
        {
            Vector3 vc = (goal.position - transform.position);
            agent.destination = transform.position + vc.normalized * (vc.magnitude - 3f);

            if (bateau)
            {
                agent.destination = goal_end.position;
            }
        }

      
    }

}
