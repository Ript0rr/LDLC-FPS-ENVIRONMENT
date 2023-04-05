using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAnimals : MonoBehaviour
{
    List<MoveTo> animals = new List<MoveTo>();

    public void AddAnimal(MoveTo animal)
    {
        if(!animals.Contains(animal))    
            animals.Add(animal);
    }

    void AllerAuBateau()
    {
        foreach (MoveTo animal in animals)
        {
            animal.bateau = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name =="zone animaux")
        {
            AllerAuBateau();
        }
    }

    public void TpAnimals(Vector3 pos)
    {
        foreach (MoveTo animal in animals)
        {
            animal.agent.isStopped = true;
            animal.agent.enabled = false;
            animal.transform.position = pos;
            animal.agent.enabled = true;
            animal.agent.isStopped = false;
        }
    }
}
