using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAnimals : MonoBehaviour
{
    List<MoveTo> animals = new List<MoveTo>();
    public UIpoint _uIManager;  
    public void AddAnimal(MoveTo animal)
    {
        if(!animals.Contains(animal))    
            animals.Add(animal);
    }        
    public void RemoveAnimal(MoveTo animal)
    {
        if(animals.Contains(animal))
               animals.Remove(animal);
    }

    void AllerAuBateau()
    { 
        for(int i = animals.Count-1; i >= 0; i--)
        {
            MoveTo animal = animals[i];
            animal.bateau = true;
            RemoveAnimal(animal);
            _uIManager.AddScore(1);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "zone animaux")
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
