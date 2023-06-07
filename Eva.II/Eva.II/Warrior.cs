
using static Weapon;

class Warrior
{
    private string name;
    private Weapon weapon;
    private Armor armor;
    private float maxHealth;
    private float currentHealth;

    public Warrior(string name, float maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }


    public float ReceiveDamage(float damage)
    {
        return currentHealth -= damage;
    }

    public float Attack(Warrior warrior, AttackType attackType, ref bool isCrit)
    {
        return warrior.ReceiveDamage(armor.MitigateDamage(weapon.GetAttackDamage(attackType, ref isCrit)));
    }

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void GetWeapon() { Console.WriteLine(this.weapon); }

    public void SetArmor(Armor armor)
    {
        this.armor = armor;
    }

    public string GetName()
    {
        Console.WriteLine(name);
        return name;
    }

    public float GetCurrentHealth()
    {
        Console.WriteLine("Vida actual: " + currentHealth.ToString());
        return currentHealth;
    }

    public bool IsAlive()
    {
        if (currentHealth <= 0f)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void GetStats()
    {
        Console.WriteLine("Name " + this.name);
        Console.WriteLine("Current Health " + currentHealth);
        Console.WriteLine("Armor " + this.armor);
        Console.WriteLine("Weapon " + this.weapon);
    }
}