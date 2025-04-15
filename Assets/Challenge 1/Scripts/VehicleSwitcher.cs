using UnityEngine;
using System.Collections.Generic;

public class VehicleSwitcher : MonoBehaviour
{
    [System.Serializable]
    public class Vehicle
    {
        public GameObject vehicleObject;
        public MonoBehaviour controller;  // Can be PlaneController, TankController, etc.
    }

    public List<Vehicle> vehicles;
    public FollowPlayerX cameraController;
    private int currentVehicleIndex = 0;

    void Start()
    {
        // Initialize all vehicles
        for (int i = 0; i < vehicles.Count; i++)
        {
            SetVehicleActive(vehicles[i], i == currentVehicleIndex);
        }

        cameraController.SetTarget(vehicles[currentVehicleIndex].vehicleObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchVehicle();
        }
    }

    void SwitchVehicle()
    {
        SetVehicleActive(vehicles[currentVehicleIndex], false);

        currentVehicleIndex = (currentVehicleIndex + 1) % vehicles.Count;

        SetVehicleActive(vehicles[currentVehicleIndex], true);
        cameraController.SetTarget(vehicles[currentVehicleIndex].vehicleObject);
    }

    void SetVehicleActive(Vehicle vehicle, bool isActive)
    {
        vehicle.controller.enabled = true; 
        if (vehicle.controller is PlaneController plane)
            plane.SetActive(isActive);
        else if (vehicle.controller is TankController tank)
            tank.SetActive(isActive);
    }
}
