using System;

namespace ConsoleApplication
{
    public class Human
    {
        public int Strength = 3,
            Intelligence = 3,
            Dexterity = 3,
            Health = 100;
        public string Name;
        public Human(string val)
        {
            Name = val;
        }
        public Human(int Str, int Dex, int Int, int HP, string Alias)
        {
            Strength = Str;
            Intelligence = Int;
            Health = HP;
            Name = Alias;
        }
    public void Attack(Human user)
    {
        Console.WriteLine(Name + " is attacking " + user.Name + "!");
        user.Health -= Strength * 5;
        Console.WriteLine(user.Name + " receives " + Strength * 5 + " pts of damage and has " + user.Health + " HP left");
    }
}
public class Program
{
    public static void Main(string[] args)
        {
            Human Quinten = new Human("Quinten");
            Human Dino = new Human("Dino");
            Console.WriteLine($"My new human name is {Quinten.Name}");
            Quinten.Attack(Dino);
        }
    }
}
