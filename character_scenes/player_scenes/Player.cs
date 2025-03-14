using Godot;
using System;

public partial class Player : Area2D
{

	[Export]
	public int speed { get; set; } = 400;
	
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
	
}
