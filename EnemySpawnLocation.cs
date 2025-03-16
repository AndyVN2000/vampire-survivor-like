using Godot;
using System;

public partial class EnemySpawnLocation : PathFollow2D
{
	
	Path2D path;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		path = GetParent<Path2D>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GlobalPosition = path.GlobalPosition;
		GD.Print(GlobalPosition);
	}
}
