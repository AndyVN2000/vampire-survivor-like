using Godot;
using System;
using static Enemy;
using static Projectile;

public abstract partial class BaseWeapon : Node
{
	
	private string _name;
	[Export] private PackedScene _projectile;
	private int _range;
	private float _damage;
	private float _cooldown;
	
	
	public virtual Enemy ComputeEnemyTarget()
	{
		return null;
	}
	
	public void Shoot()
	{
		_projectile.Instantiate<Projectile>();
	}
	
}
