# Unity Flocking System with Jobs & Burst

This project implements a performant and scalable boid-like flocking system in Unity using the **C# Job System** and **Burst Compiler**. Each unit is a `MonoBehaviour`, but its logic is parallelized using `IJobParallelFor`, enabling efficient behavior updates for large numbers of agents.

---

## ✨ Features

- Parallelized movement updates using Unity's **C# Job System**
- Behavior logic:
  - **Cohesion**: move toward local flockmates
  - **Avoidance**: steer away from nearby agents
  - **Alignment**: match heading with nearby agents
  - **Bounds**: steer back toward center of flock area
- Randomized flock parameter generation
- **Burst Compilation** for optimized math-heavy operations
- `NativeList<T>[]` used to store per-agent neighbor data
- Inspector-exposed fields for behavior weight tuning

---

## 🔧 How It Works

1. **Units are spawned randomly** in a bounded 3D area.
2. **In `Update()`**, each agent gathers its nearby neighbors into `NativeList<T>[]` buffers.
3. These buffers are currently prepared but not yet fed into the `MoveJob` system.
4. A `MoveJob` runs with placeholder arrays to update movement vectors in parallel.
5. Final positions/rotations are applied back to each GameObject after the job finishes.

---

## 🎮 How To Use

1. Attach `Flock.cs` to a GameObject in the scene.
2. Assign the `FlockUnit` prefab.
3. Tweak behavior weights and distances in the Inspector.
4. Play the scene to see units move with basic flocking logic.
