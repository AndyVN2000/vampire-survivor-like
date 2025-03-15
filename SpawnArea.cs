using Godot;
using System;

public partial class SpawnArea : Node2D
{
	
	Camera2D camera;
	
	public override void _Ready()
	{
		camera = GetNode<Camera2D>("../Player/Camera2D");
		GD.Print("Hello");
		GD.Print(camera.Position);
	}
	
}
