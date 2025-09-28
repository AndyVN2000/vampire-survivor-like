using Godot;
using System;

public partial class Mob : CharacterBody2D, Enemy
{
	
	Area2D player;
	NavigationAgent2D navigationAgent;
	[Export]
	int MovementSpeed = 100;
	
	int Damage = 10;
	private EnemyHealth _health;
	
	public Mob()
	{
		_health = new EnemyHealth(100);
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = (Area2D) GetTree().GetNodesInGroup("Players")[0];
		navigationAgent = GetNode<NavigationAgent2D>("NavigationAgent2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		var currentAgentPos = GlobalPosition;
		var playerPos = player.GlobalPosition;
		Velocity = currentAgentPos.DirectionTo(playerPos) * MovementSpeed;
		MoveAndSlide();
	}
	
	public int GetDamage()
	{
		return Damage;
	}
	
	public int GetHealth()
	{
		return _health.CurrentHealth;
	}
	
	public void ChangeHealthBy(int amount)
	{
		_health.ChangeHealthBy(amount);
	}
}
