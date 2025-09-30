using Godot;
using System;

namespace VampireSurvivorLike.weapons.@interface
{
    public interface IWeapon
    {
        public void Initialize(Player player);

        public void Shoot();
    }
}