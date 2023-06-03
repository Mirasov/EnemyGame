using UnityEngine;

public class Car
{
    public Color Color;
    public string Creator;
    public string Model;

    private float _speed;
    private float _wheelRotation;

    public Car(Color color, string creator, string model)
    {
        Color = color;
        Creator = creator;
        Model = model;
    }

    public void Move()
    {
        _speed = 10;
    }

    public void Stop()
    {
        _speed = 0;
    }

    public void Rotate(float angle)
    {
        _wheelRotation = angle;
    }
}