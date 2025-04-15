# Create With Code - Unit 1: Player Control (Extended)

This is my solution to **Unit 1: Player Control** from Unity's official tutorial:

- [Unity "Create with Code" Tutorial](https://learn.unity.com/course/create-with-code?uv=6)

## About this Project

The original goal of Unit 1 is to set up basic player control for a plane using simple 2D movement. However, I've enhanced the original project by:

- Upgrading the plane movement to full **3D controls**, allowing realistic movement and rotation.
- Adding an additional vehicle—a **tank**—with completely distinct movement mechanics.
- Implementing the ability to dynamically switch control between the plane and the tank using the **Spacebar**.

## How to Use

- Press **Spacebar** at any time to switch between controlling the plane and the tank.
- Use the arrow keys (`↑`, `↓`, `←`, `→`) or `WASD` to move and rotate the currently active vehicle.

## Project Structure

- `PlaneController.cs`: Controls the plane movement in full 3D.
- `TankController.cs`: Handles tank-specific movements.
- `VehicleSwitcher.cs`: Allows switching between vehicles and updates camera targets.
- `FollowPlayerX.cs`: Smoothly follows the currently active vehicle with the camera.

## Tutorial Reference

[Unity Create With Code (Unit 1)](https://learn.unity.com/course/create-with-code?uv=6)

---


