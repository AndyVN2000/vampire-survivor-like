using Godot;
using System;
using static Projectile;

public abstract partial class BaseWeapon : Node
{
	
	private string _name;
	[Export] private PackedScene _projectile;
	private int _range;
	private float _damage;
	private float _cooldown;
	
	public void Shoot()
	{
		_projectile.Instantiate<Projectile>();
	}
	
}
