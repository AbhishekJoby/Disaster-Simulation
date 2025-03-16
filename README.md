# Fire Escape Simulation - Blackbox Model

Welcome to the **Fire Escape Simulation** repository! This repository contains the code for the **blackbox model** of our modular software designed to create interactive simulations for educational purposes. The project currently focuses on **Disaster Management** and **Fire Hazard Training**, providing a gamified experience to teach essential survival skills in hazardous situations.

> **Note:** This repository includes only the core codebase of the blackbox model (no graphical assets). The final release with full features was too large for GitHub.
> The Game Design Document submitted can also be found on the root of the repo as **GDD- Fire Escape Simulation.pdf**

---

## Project Overview

**Fire Escape: Survival Training** is an educational simulation game that teaches players how to react and escape safely during an apartment fire. Through interactive scenarios and real-life safety tips, players learn essential survival skills such as:

- Navigating through smoke-filled environments.
- Using fire extinguishers correctly.
- Making critical decisions under pressure.

The game is built as a modular system, allowing future expansions for other disaster scenarios.

---

## Repository Structure

The core scripts and code files for the project are located in the following directories:

- `/Assets/`  
  Contains all assets used in the simulation, including some scripts, prefabs, and other resources.

- `/Assets/Scripts/`  
  This folder contains all the main C# scripts that power the simulation's functionality. other scripts we wrote are in the 'Assets' folder 

### Key C# Files

Below are the main C# scripts in `/Assets/Scripts/` that drive the core mechanics of the simulation:

1. **`areaTrigger.cs`**  
   Handles trigger zones within the environment, such as fire zones or safe areas.

2. **`Interactable.cs`**  
   Defines objects in the environment that players can interact with, such as doors and extinguishers.

3. **`PlayerInteract.cs`**  
   Manages player interactions with objects in the environment.

4. **`playerStat.cs`**  
   Tracks player health, stamina, and other stats affected by environmental hazards like smoke or fire.

5. **`fire.cs`**  
   Implements dynamic fire behavior, including spread mechanics and interaction with environmental factors like oxygen levels.

6. **`fireextinguisher.cs`**  
   Controls fire extinguisher mechanics, including pickup, usage, and extinguishing functionality.

---

## Features of the Blackbox Model

### Reactive Environment
- Smoke accumulation reduces visibility and affects player stats.

### Player Movement and Interaction
- Players can crouch to avoid smoke and heat.
- Interaction system allows players to check doors, use fire extinguishers, and navigate escape routes.

### Decision Points
Players face critical decisions during gameplay:
- Choosing between safe or dangerous escape routes.
- Using appropriate fire extinguishers for different types of fires.(not in the build)

### Consequences
Actions have immediate consequences:
- Opening a fire door may cause explosions.
- Breaking windows can intensify flames.(not in the build)
- Choosing incorrect tools or routes leads to failure scenarios.

---

## How to Run

To run this simulation:

Download the build file that has the graphics implemented

or for the blackbox model..

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/fire-escape-simulation-blackbox.git
   ```
2. Open the project in Unity (version 2021.x or later recommended).
3. Navigate to `/Assets/Scenes/` and open the main scene.
4. Press `Play` in Unity Editor to start testing the blackbox model.

---

## Future Plans

This blackbox model is part of a larger project aimed at expanding into various disaster management scenarios. Future updates may include:

- Graphics and animations (available in separate repositories).
- Additional disaster scenarios (e.g., earthquakes, floods).
- Enhanced analytics for player performance evaluation.

---



---

We hope this simulation helps educate people about disaster management in an engaging way! For any questions or feedback, feel free to open an issue or contact us directly.
