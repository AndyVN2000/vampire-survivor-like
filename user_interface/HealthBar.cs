using Godot;
using System;

public partial class HealthBar : ProgressBar
{
	[Export]
	Player player { get; set; }
	
	public void update()
	{
		Value = player.currentHealth * 100 / player.maxHealth;
	}
	
}
