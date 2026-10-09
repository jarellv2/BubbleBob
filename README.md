# Bubble Bobble 2D Prototype

## Part 1: Scene Setup
The scene is a 2D prototype representing the core gameplay loop of Bubble Bobble. Because the original game is a 2D platformer, I used  2D objects and sprites such as square for Player, circle for Enemy, and a stretched Square for the floorto better match the arcade perspective and physical interactions. The 2D camera setup acts as the single screen level constraint found in the original game.

## Part 2: Object-Oriented Programming (OOP)
* **What was done:** I implemented an abstract base class `Character` and derived `Player` and `Enemy` classes from it.
* **How it was done:** I used **Inheritance** (`Player : Character`), **Abstraction/Polymorphism** (`public abstract void Move()`), and **Encapsulation** (`protected float speed` accessible only to derived classes).
* **Why it was done:** This centralizes shared logic (like the `Die()` method). If I want to add new enemy types later, they just inherit from `Character` without going and rewriting the movement framework or health data, keeping the codebase organized and clean.

## Part 3: Singleton Pattern
* **What was done:** Implemented a global `ScoreManager`.
* **How it was done:** Created a static instance of the class that checks  `Awake()` for a duplicate. If a duplicate exists, it destroys itself; otherwise, it continues using `DontDestroyOnLoad`.
* **Why it was done:** In Bubble Bobble, scoring happens continuously across multiple  levels. The Singleton makes sure only one central score exists, and allows enemies to instantly award points (`ScoreManager.Instance.AddScore`) when defeated without needing complex component references wired in the inspector.

## Part 4: Factory Pattern
* **What was done:** Implemented a `BubbleFactory` to handle projectile instantiation.
* **How it was done:** The Player script does not instantiate objects directly. Instead, it calls `BubbleFactory.Instance.CreateBubble()`. The Factory handles the creation, scaling, material coloring (green), and physics application.
* **Why it was done:** Firing bubbles is the core mechanic. By isolating creation into a Factory, if I later want to implement elemental bubbles (e.g., fire or water bubbles), I only modify the Factory logic. This adheres to the Single Responsibility Principle and keeps the Player class strictly focused on movement.

