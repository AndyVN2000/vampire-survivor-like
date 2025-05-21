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
- Health [DONE]
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

# Implementation notes

## Auto-attacking
The player needs to know which direction to auto-attack:
	1. Find the closest enemy.
	2. Direct a shot towards that enemy.

Step 1 is the hardest part. How do should the player keep track of the closest enemy at all times?
If I do it wrong, then it will be very computation heavy.

Ideas of tracking enemy position:
	Brute force: Group all enemies in a scene group. Let player access that group so he can see all
		enemies. Then compute the closest enemy... while the game is running in real-time...
	Range indicator: Define a specific range in which the auto-attacking player will react. When
		enemies enter the range, the player will track their movements and fire.
	

# Refactorization

I should replace Mob scene with a general Enemy scene. It's health logic will be fixed and enemy 
types will be a variable component that should be easily attached to the Enemy scene like a delegate
in compositional design.
