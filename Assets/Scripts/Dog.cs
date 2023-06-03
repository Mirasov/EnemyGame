using UnityEngine;

public class Dog : Animal
{
    public float Heigh;

    public Dog(string name, Color color) : base(name, color)
    {
        ObjectType = PrimitiveType.Cube;

        Debug.Log($"Animal: Dog, Name: {Name}, Color: {Color}, Heigh: {Heigh}");
        Eat();
    }
}

