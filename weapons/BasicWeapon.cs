using Godot;
using System;

public partial class BasicWeapon : BaseWeapon
{

    public override void _Ready()
    {
        _name = "Basic Weapon";
        _cooldown = 3.0f;
        _timer = 0.0f;
    }

}
