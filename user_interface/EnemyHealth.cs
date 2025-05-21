using Godot;
using System;

public partial class EnemyHealth : Node
{
	
	private int _maxHealth;
	private int _currentHealth;
	public int CurrentHealth => _currentHealth;
	
	public EnemyHealth(int maxHealth)
	{
		_maxHealth = maxHealth;
		_currentHealth = maxHealth;
	}
	
	public void ChangeHealthBy(int amount)
	{
		_currentHealth += amount;
	}
	
	public bool IsFull()
	{
		return _currentHealth == _maxHealth;
	}
	
}
