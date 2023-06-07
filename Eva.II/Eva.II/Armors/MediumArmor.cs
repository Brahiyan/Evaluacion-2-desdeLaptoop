class MediumArmor : Armor
{
    public MediumArmor()
    {
        this.name = "MEDIUM ARMOR";
        this.weight = 1;
        this.defense = 15;
    }

    public override float MitigateDamage(float damage)
    {
        //if (defense == damage) return damage / (1 + defense / 100);
        //else { return damage / (defense * 0.70f); }
        return damage / (1 + defense / 125);
        //100 x 100 / 80 es el porcentaje máximo del daño reducido.

    }
}