using System;
public abstract class Weapon
{
    protected string name;
    protected float attack;
    public Weapon()
    {
    }

    public abstract float GetAttackDamage(AttackType attackType, ref bool isCrit);


}