using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAnimals : MonoBehaviour
{
    List<MoveTo> animals;

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
}
