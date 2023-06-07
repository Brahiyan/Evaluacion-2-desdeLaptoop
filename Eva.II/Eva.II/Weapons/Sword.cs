
public class Sword : Weapon
{
    private float baseAttack;
    protected int baseCriticalRate;
    protected int criticalRate;
    protected float baseCriticalDamage;
    protected float criticalDamage;

    public Sword(string name, float attack, int baseCriticalRate, float baseCriticalDamage) 
    {
        this.name = name;
        this.attack = attack;
        this.baseCriticalRate = baseCriticalRate;
        this.baseCriticalDamage = baseCriticalDamage;
        baseAttack = attack;
    }

    public void GetAttack()
    {
        Console.WriteLine("ataque: " + attack);

    }

    public override float GetAttackDamage(AttackType attackType, ref bool isCrit)
    {
        isCrit = false;
        criticalDamage = baseCriticalDamage;
        criticalRate = baseCriticalRate;
        attack = baseAttack;


        if (attackType == AttackType.FAST)
        {
            criticalRate = 25;
            Random rnd = new Random();
            isCrit = (rnd.Next(0, 100) <= criticalRate) ? true : false;
            Console.WriteLine(rnd);

            if (isCrit == true) attack = attack * criticalDamage;

        }

        else if (attackType == AttackType.NORMAL)
        {
            criticalRate = 20;
            Random rnd = new Random();
            isCrit = (rnd.Next(0, 100) <= criticalRate) ? true : false;


            if (isCrit == true) attack = attack * criticalDamage;

        }

        else if (attackType == AttackType.CHARGED)
        {
            criticalRate = 20;
            criticalDamage = 2.5f;
            Random rnd = new Random();
            isCrit = (rnd.Next(0, 100) <= criticalRate) ? true : false;

            if (isCrit == true) attack = attack * criticalDamage;

        }

        return attack;
    }


}