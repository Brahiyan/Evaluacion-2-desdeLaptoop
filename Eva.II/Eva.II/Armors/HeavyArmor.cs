class HeavyArmor: Armor
{
    public HeavyArmor()
    {
        this.name = "HEAVY ARMOR";
        this.weight = weight;
        this.defense = 20;
    }

    public  override float MitigateDamage(float damage)
    {
        return damage / (1 + defense / 111);
        //100 x 100 / 90 es el porcentaje máximo del daño reducido.
    }
}