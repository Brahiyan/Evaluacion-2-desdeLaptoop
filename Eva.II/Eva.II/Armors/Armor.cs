public abstract class Armor
{
    protected string name;
    protected float defense;
    protected float weight;

    public Armor()
    {
        this.name = name;
        this.defense = defense;
        this.weight = weight;
    }

    public abstract float MitigateDamage(float damage);
    

}