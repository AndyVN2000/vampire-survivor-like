using Godot;
using System;

public partial class SpawnPath : Node2D
{
	[Export]
	public Camera2D camera;
	
	public override void _Ready()
	{
		//camera = GetNode<Camera2D>("../../Player/Camera2D");
	}
	
	public override void _Process(double delta)
	{
		GlobalPosition = camera.GlobalPosition;
		GD.Print(GlobalPosition);
	}
	
}
