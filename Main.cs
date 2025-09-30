using Godot;
using System;

public partial class Main : Node
{
	[Export]
	PackedScene EnemyScene;
	
	
	public override void _Ready()
	{
		GetNode<Timer>("SpawnArea/EnemySpawnTimer").Start();
	}
	
	
	
	private void OnEnemySpawnTimerTimeout()
	{
		GD.Print("Enemy spawned");
		
		Node2D enemy = EnemyScene.Instantiate<Node2D>();
		
		var enemySpawnLocation = GetNode<PathFollow2D>("SpawnArea/SpawnPath/EnemySpawnLocation");
		enemySpawnLocation.ProgressRatio = GD.Randf();
		
		enemy.GlobalPosition = enemySpawnLocation.GlobalPosition;
		
		AddChild(enemy);
		
	}
}
