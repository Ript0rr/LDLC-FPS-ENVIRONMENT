using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class teleportation1 : MonoBehaviour
{
    public Transform pointDarrivee;

    private void OnTriggerEnter(Collider other)
    {
        var ac = other.GetComponentInParent<CollectAnimals>();

        if (ac != null)
        {
            ac.TpAnimals(pointDarrivee.position);
            other.transform.position = pointDarrivee.position;
        }
    }
}