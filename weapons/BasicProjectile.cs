using Godot;
using System;

public partial class BasicProjectile : Projectile
{

	AnimatedSprite2D _sprite;
	TargetingUtil _targetingUtil;
	Vector2 _direction;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_sprite.Play();
		_targetingUtil = new TargetingUtil();
		Vector2 targetPosition = _targetingUtil.ComputeTargetPosition(this, this.GlobalPosition);
		// GD.Print("Position of enemy: " + targetPosition);
		_direction = Position.DirectionTo(targetPosition);
		// GD.Print("Direction of projectile: " + _direction);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += _direction;
	}
}
