using UnityEngine;

public class Animal
{
    public string Name;
    public Color Color;
    public PrimitiveType ObjectType;

    public Animal(string name, Color color)
    {
        Name = name;
        Color = color;
    }

    public void Eat()
    {
        Debug.Log($"Animal {Name}: eating ");
    }
}
