# Unity-Arcade-Defense-Game

\# 2D Arcade Defense: Dogs vs Balls



A dynamic 2D arcade game developed in Unity (C#), focusing on object management, physics-based interactions, and progressive difficulty systems. The player controls a spawner to defend against falling projectiles with unique behaviors.



\## 🎮 Gameplay Features

\* \*\*Dynamic Spawning System:\*\* Balls spawn from random locations with randomized intervals (3s - 5s).

\* \*\*Progressive Difficulty:\*\* The game becomes harder as time progresses by increasing the spawn rate of enemies.

\* \*\*Unique Enemy AI:\*\* Implemented 3 different ball behaviors:

   \* \*Speedsters:\* Move faster than standard objects.

   \* \*Tricky Balls:\* Change direction mid-fall.

   \* \*Splitters:\* Split into smaller projectiles upon interaction.

\* \*\*Game Loop \& Managers:\*\*

   \* 60-second countdown timer.

   \* Real-time scoring system.

   \* "Game Over" state with final score display and Restart functionality.



\## 🛠 Technical Implementation

This project demonstrates proficiency in the following Unity/C# concepts:

\* \*\*Physics \& Collision:\*\* handled via `OnCollisionEnter` and `OnTriggerExit` for boundary checks (destroying objects off-screen).

\* \*\*Input Handling:\*\* Player movement logic using keyboard inputs (WASD/Arrow Keys).

\* \*\*UI Management:\*\* Canvas integration for Timer, Score, and Menu screens.

\* \*\*Audio System:\*\* Trigger-based sound effects for spawning, destruction, and game-over events.



\## 🕹️ Controls

\* \*\*Movement:\*\* `Arrow Keys` or `W, A, S, D` to move the dog spawner.

\* \*\*Objective:\*\* Spawn dogs to intercept falling balls before they hit the bottom.

## 🚀 Getting Started

1.  Clone the repo:
    ```bash
    git clone [https://github.com/KULLANICI_ADIN/REPO_ISMIN.git](https://github.com/KULLANICI_ADIN/REPO_ISMIN.git)
    ```
2.  Open **Unity Hub**.
3.  Click **"Add"** and select the cloned folder.
4.  Open the project (Recommended Unity Version: 2021.3 LTS or newer).
5.  Open the `Scenes/Challenge2 scene to start.

---
*Developed by [Yiğithan Kuraner] - Computer Engineering Student @ ESTÜ*





