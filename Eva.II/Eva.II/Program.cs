using System;

class Program
{
    static void Main()
    {
        bool isCrit = false;       

        CharacterCreator player1 = new CharacterCreator();
        CharacterCreator player2 = new CharacterCreator();
        player1.CreateWarrior();
        player2.CreateWarrior();
        
        player1.GetWarrior().Attack(player2.GetWarrior(), AttackType.NORMAL, ref isCrit);
        player1.warrior.Attack(player2.warrior, AttackType.CHARGED, ref isCrit);


        player1.GetWarrior().GetStats();
        player2.GetWarrior().GetStats();

        
    }
}