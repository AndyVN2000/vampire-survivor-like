# vampire-survivor-like
A game based on Vampire Survivors. Developed in Godot

# TODO list

Map/stage
- Basic ground texture [DONE]
- Map bounds
- Camera following Player [DONE]

Enemies
- Spawns just beyond the bounds of screen [DONE]
-- Spawn area should follow the position of camera [DONE]
- Health
- Can lose health
- Chases the player [DONE]
- Deals collision damage to player [DONE]

Player
- Health [DONE]
- Can lose health [DONE]
- Game over when health reaches 0
- Can auto-attack

User Interface
- Health bar [DONE]
- Timer
- Main menu

Upgrades

# Refactorization
I should replace Mob scene with a general Enemy scene. It's health logic will be fixed and enemy 
types will be a variable component that should be easily attached to the Enemy scene like a delegate
in compositional design.
