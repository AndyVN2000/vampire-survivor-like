using Godot;
using System;

public partial class HealthBar : ProgressBar
{
	[Export]
	Player player { get; set; }
	
	public override void _Ready()
	{
		// Connect the DamageTaken signal to Update().
		player.DamageTaken += Update;
	}
	
	public void Update()
	{
		GD.Print("PLAYER HAS TAKEN DAMAGE");
		// Update the display of Player health
		Value = player.currentHealth * 100 / player.maxHealth;
	}
	
}
