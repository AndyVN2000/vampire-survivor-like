using Godot;
using System;
using System.Collections.Generic;

public partial class TestTimer : Timer
{
	private Area2D _player;
	private int _spawnCount = 0;
	private List<Node2D> _spawnPoints = new List<Node2D>();
	[Export] private PackedScene _mobScene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = (Area2D)GetNode("../Player");
		_spawnPoints.Add((Node2D)GetNode("../Node2D0"));
		_spawnPoints.Add((Node2D)GetNode("../Node2D1"));
		_spawnPoints.Add((Node2D)GetNode("../Node2D2"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnTimeout()
	{
		Node2D spawnPoint = _spawnPoints[_spawnCount];
		Mob mob = _mobScene.Instantiate<Mob>();
		mob.SetMovementSpeed(0);
		mob.GlobalPosition = spawnPoint.GlobalPosition;
		GetParent().AddChild(mob);
	}
}
