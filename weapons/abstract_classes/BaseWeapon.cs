using Godot;
using System;
using static Projectile;

public abstract partial class BaseWeapon : Node
{
	public Player Owner { get; private set; }
	
	private string _name;
	[Export] private PackedScene _projectileScene;
	private int _range;
	private float _damage;
	private float _cooldown;
	private float _timer;
	
	public override void _Ready()
	{}
	
	public override void _Process(double delta)
	{
		_timer -= (float)delta;
		if (_timer <= 0)
		{
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
