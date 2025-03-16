using Godot;
using System;

public partial class Mob : RigidBody2D
{
	
	Area2D player;
	NavigationAgent2D navigationAgent;
	[Export]
	int movementSpeed = 400;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = (Area2D) GetTree().GetNodesInGroup("Players")[0];
		navigationAgent = GetNode<NavigationAgent2D>("NavigationAgent2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		if (navigationAgent.IsNavigationFinished())
		{
			return;
		}
		
		var currentAgentPos = GlobalPosition;
		var playerPos = player.GlobalPosition;
		Velocity = currentAgentPos.DirectionTo(playerPos) * movementSpeed;
	}
}
