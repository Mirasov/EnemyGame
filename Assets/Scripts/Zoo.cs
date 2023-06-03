using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    public List<Animal> Animals;

    private void Start()
    {
        Animals = new List<Animal>();

        Animal cat = new Cat("Barsik", Color.black);
        Animal cat2 = new Cat("Morda", Color.blue);
        Animal cat3 = new Cat("Naglaya", Color.clear);

        Animal dog = new Dog("Bobik", Color.white);
        Animal dog2 = new Dog("Persik", Color.yellow);
        Animal dog3 = new Dog("Pesel", Color.green);

        Animals.Add(cat);
        Animals.Add(cat2);
        Animals.Add(cat3);

        Animals.Add(dog);
        Animals.Add(dog2);
        Animals.Add(dog3);

        CreateAnimals();
    }

    private void CreateAnimals()
    {
        int x = 0;
        foreach(Animal animal in Animals)
        {
            GameObject animalObject = GameObject.CreatePrimitive(animal.ObjectType);

            animalObject.name = $"{animal.Name}";
            animalObject.transform.position = new Vector3(x, 0, 0);
            animalObject.GetComponent<MeshRenderer>().material.color = animal.Color;

            x++;
        }
    }
}
