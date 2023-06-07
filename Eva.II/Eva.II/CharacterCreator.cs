class CharacterCreator 
{
    public Warrior warrior;
    private Weapon weapon;
    private Armor armor;


    //public CharacterCreator() 
    //{
    //}
    public Warrior CreateWarrior()
    {
        string name = "Placeholder";
        float health = 100;
        ConsoleKeyInfo key;

        Console.Write("Nombre: ");
        name = Console.ReadLine();

         warrior = new Warrior( name, health);

        //SELECCIÓN DE ARMAS

        Console.WriteLine("Que arma deseas equipar? ");
        Console.WriteLine("1. Sword");
        Console.WriteLine("2. Axe");
        Console.WriteLine("3. Spear");

        key = Console.ReadKey();
        if (key.Key == ConsoleKey.D1) warrior.SetWeapon(new Sword("SWORD", 20, 20, 1.5f));
        if (key.Key == ConsoleKey.D2) warrior.SetWeapon(new Axe("AXE", 25, 10, 3.5f));
        if (key.Key == ConsoleKey.D3) warrior.SetWeapon(new Spear("SPEAR", 15, 25, 2.5f));

        //SELECCIÓN DE ARMADURA

        Console.WriteLine("Que armadura deseas equipar? ");
        Console.WriteLine("1. Light Armor");
        Console.WriteLine("2. Medium Armor");
        Console.WriteLine("3. Heavy Armor");

        key = Console.ReadKey();
        if (key.Key == ConsoleKey.D1) warrior.SetArmor(new LightArmor());
        if (key.Key == ConsoleKey.D2) warrior.SetArmor(new MediumArmor());
        if (key.Key == ConsoleKey.D3) warrior.SetArmor(new HeavyArmor());

        return warrior;
    }

    public Warrior GetWarrior()
    {
        return warrior;
    }


}