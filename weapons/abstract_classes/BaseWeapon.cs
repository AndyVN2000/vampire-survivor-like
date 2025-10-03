using Godot;
using System;
using VampireSurvivorLike.weapons.@interface;
using static Projectile;

public abstract partial class BaseWeapon : Node, IWeapon
{
	public Player Owner { get; private set; }
	
	protected string _name;
	[Export] protected PackedScene _projectileScene;
	protected float _cooldown;
	protected float _timer;
	
	public override void _Ready()
	{}
	
	public override void _Process(double delta)
	{
		_timer -= (float)delta;
		if (_timer <= 0)
		{
			// GD.Print("Firing shot");
			Shoot();
			_timer = _cooldown;
		}
	}
	
	public void Initialize(Player player)
	{
		Owner = player;
	}
	
	public void Shoot()
	{
		var projectile = _projectileScene.Instantiate<Projectile>();
		projectile.GlobalPosition = Owner.GlobalPosition;
		GetTree().CurrentScene.AddChild(projectile);
	}
	
}
