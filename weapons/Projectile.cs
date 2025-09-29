using Godot;
using System;

public abstract partial class Projectile : Area2D
{
	private Vector2 Direction;
	private float speed;
	
	public virtual void Initialize(Vector2 startPosition, Vector2 direction)
	{
		GlobalPosition = startPosition;
		Direction = direction.Normalized();
	}
}
