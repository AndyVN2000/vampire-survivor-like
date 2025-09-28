using Godot;
using System;
using static Enemy;

public abstract partial class BaseWeapon : Node
{
	private string name;
	private int range;
	private float damage;
	private float cooldown;
	
	public virtual Enemy ComputeEnemyTarget()
	{
		return null;
	}
	
}
