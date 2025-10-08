using Godot;
using System;
using System.Collections.Generic;
using static Enemy;

public partial class TargetingUtil : Node
{

	public Node2D ComputeClosestEnemy(Node caller, Vector2 currentPosition)
	{
		GD.Print("Player position: " + currentPosition);
		var enemies = caller.GetTree().GetNodesInGroup("EnemiesInRange");
		GD.Print("Enemy count: " + enemies.Count);
		Node2D closestEnemy = null;
		float closesDistance = float.MaxValue;
		foreach (Node2D enemy in enemies)
		{
			GD.Print("Enemy postion" + enemy.GlobalPosition);
			float distance = currentPosition.DistanceSquaredTo(enemy.GlobalPosition);
			if (closestEnemy == null || distance < closesDistance)
			{
				closestEnemy = enemy;
				closesDistance = distance;
			}
		}
		return closestEnemy;
	}

	public Vector2 ComputeTargetPosition(Node caller, Vector2 currentPosition)
	{
		return ComputeClosestEnemy(caller, currentPosition).GlobalPosition;
	}
	
}
