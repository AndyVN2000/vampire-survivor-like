using Godot;
using System;

public partial class EnemyHealth : Node
{
	
	int maxHealth;
	int currentHealth;
	
	public void changeHealthBy(int amount){
		currentHealth += amount;
	}
	
}
