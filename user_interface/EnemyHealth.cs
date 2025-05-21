using Godot;
using System;

public partial class EnemyHealth : Node
{
	
	private int _maxHealth;
	private int _currentHealth;
	
	public EnemyHealth(int maxHealth)
	{
		_maxHealth = maxHealth;
		_currentHealth = maxHealth;
	}
	
	public void changeHealthBy(int amount)
	{
		_currentHealth += amount;
	}
	
	public bool isFull()
	{
		return _currentHealth == _maxHealth;
	}
	
}
