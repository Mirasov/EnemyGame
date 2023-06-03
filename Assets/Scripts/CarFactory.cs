using System;
using UnityEngine;

class CarFactory : MonoBehaviour
{
    private void Start()
    {
        Car car = CreateCar();

        Debug.Log($"Car color: {car.Color}, creator: {car.Creator}, model: {car.Model}");
    }

    public Car CreateCar()
    {
        Car audi = new Car(Color.yellow, "Audi", "Q8");

        return audi;
    }
}

