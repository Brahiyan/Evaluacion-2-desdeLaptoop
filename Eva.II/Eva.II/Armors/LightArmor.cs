class LightArmor : Armor
{
        public LightArmor() 
        {
            this.name = "LIGHT ARMOR";
            this.weight = weight;
            this.defense = 10; 
        }

    public override float MitigateDamage(float damage)
    {
        return damage / (1 + defense / 142);
        //100 x 100 / 70 es el porcentaje máximo del daño reducido.

    }
}
