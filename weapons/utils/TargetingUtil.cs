using Godot;
using System;
using System.Collections.Generic;
using static Enemy;

public partial class TargetingUtil : Node
{

	public Node2D ComputeClosestEnemy(Node caller, Vector2 currentPosition)
	{
		var enemies = caller.GetTree().GetNodesInGroup("EnemiesInRange");
		Node2D closestEnemy = null;
		float closesDistance = float.MaxValue;
		foreach (Node2D enemy in enemies)
		{
			float distance = currentPosition.DistanceSquaredTo(enemy.Position);
			if (closestEnemy == null || distance < closesDistance)
			{
				closestEnemy = enemy;
			}
		}
		return closestEnemy;
	}

	public Vector2 ComputeTargetPosition(Node caller, Vector2 currentPosition)
	{
		return ComputeClosestEnemy(caller, currentPosition).Position;
	}
	
}
