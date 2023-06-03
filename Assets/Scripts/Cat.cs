using UnityEngine;

public class Cat : Animal
{
    public int LifeCount;

    public Cat(string name, Color color) : base(name, color)
    {
        ObjectType = PrimitiveType.Capsule;

        Debug.Log($"Animal: Cat, Name: {Name}, Color: {Color}, LifeCount: {LifeCount}");
        Eat();
    }

    public void Say()
    {
        Debug.Log("Cat says: Mew");
    }
}