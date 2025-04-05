using Godot;
using System;

interface Enemy
{
	int GetDamage();
	
	int GetHealth();
	
	void ChangeHealthBy(int amount);
}
