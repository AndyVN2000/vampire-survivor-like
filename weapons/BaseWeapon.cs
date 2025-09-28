using Godot;
using System;
using static Enemy;

public abstract partial class BaseWeapon : Node
{
	
	public virtual Enemy ComputeEnemyTarget()
	{
		return null;
	}
	
}
