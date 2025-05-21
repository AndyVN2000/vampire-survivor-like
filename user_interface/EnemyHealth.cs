using Godot;
using System;

public partial class EnemyHealth : Node
{
	
	int maxHealth { get; set};
	int currentHealth { get; set};
	
	public void changeHealthBy(int amount){
		currentHealth.set(currentHealth.get() + amount);
	}
	
}
