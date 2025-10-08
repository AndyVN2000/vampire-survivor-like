using Godot;
using System;

public partial class AttackRange : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnBodyEntered(Node2D body)
	{
		// GD.Print("Something entered attack range");
		if (body.GetType() == typeof(Enemy))
		{
			// GD.Print("It was an Enemy!");
			body.AddToGroup("EnemiesInRange");
		}
	}

	private void OnBodyExited(Node2D body)
	{
		if (body is Enemy)
		{
			// GD.Print("Enemy exited range!");
			body.RemoveFromGroup("EnemiesInRange");
		}
	}
}
