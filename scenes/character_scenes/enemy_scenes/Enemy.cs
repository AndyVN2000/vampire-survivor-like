using Godot;
using System;

public interface Enemy
{
	int GetDamage();
	
	int GetHealth();
	
	void ChangeHealthBy(int amount);
}
