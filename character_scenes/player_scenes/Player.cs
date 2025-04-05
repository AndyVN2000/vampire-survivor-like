using Godot;
using System;

public partial class Player : Area2D
{
	[Signal]
	public delegate void DamageTakenEventHandler();

	[ExportGroup("Player stats")]
	[Export]
	public int speed { get; set; } = 400;
	[Export]
	public int maxHealth { get; set; } = 100;
	[Export]
	public int currentHealth { get; set; } = 100;
	
	public override void _Ready()
	{}
	
	public override void _Process(double delta)
	{
		
		var velocity = Vector2.Zero; // Player's movement vector
		
		// Read the movement inputs
		if (Input.IsActionPressed("move_right"))
		{
			velocity.X += 1;
		}
		if (Input.IsActionPressed("move_left"))
		{
			velocity.X -= 1;
		}
		if (Input.IsActionPressed("move_up"))
		{
			velocity.Y -= 1;
		}
		if (Input.IsActionPressed("move_down"))
		{
			velocity.Y += 1;
		}
		
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		if (velocity.Length() > 0)
		{
			// Movement speed is normalized
			velocity = velocity.Normalized() * speed;
			animatedSprite2D.Play();
		}
		else
		{
			animatedSprite2D.Stop();
		}
		
		Position += velocity * (float)delta;
	}
	
	/* Something entered the body of the Player.
	If it is an enemy or enemy projectile, then emit a signal that
	damage has been taken. */
	private void OnBodyEntered(Node body)
	{
		GD.Print("BODY ENTERED");
		if (body is Enemy)
		{
			var enemy = (Enemy) body;
			currentHealth -= enemy.GetDamage();
			EmitSignal(SignalName.DamageTaken);
		}
	}
	
}
