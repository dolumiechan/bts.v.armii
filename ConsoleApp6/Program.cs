using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
public abstract class Character
{
    private string name;
    private int health;
    protected Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
    public virtual void Attack()
    {
        Console.WriteLine("Персонаж атакует!");
    }
    public virtual void Defend()
    {
        Console.WriteLine("Персонаж защищается!");
    }
}
class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health)
    {
    }
    public override void Attack()
    {
        Console.WriteLine("Мечом пупупу");
    }
    public override void Defend()
    {
        Console.WriteLine("Щитом пупупу");
    }
}
class Mage : Character
{
    public Mage(string name, int health) : base(name, health)
    {

    }
    public override void Attack()
    {
        Console.WriteLine("Палкой вжух вжух");
    }
    public override void Defend()
    {
        Console.WriteLine("Защитным барьером пумпум");
    }
}
class Rogue : Character
{
    public Rogue(string name, int health) : base(name, health)
    {
    }
    public override void Attack()
    {
        Console.WriteLine("Кулаками бумбум");
    }
    public override void Defend()
    {
        Console.WriteLine("Кулаками бомбом");
    }
}
