using static System.Console;
using JogoRPGDIO.src.Entitities;

namespace JogoRPGDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
            Ninja rakish = new Ninja("Rakish", 25, "Ninja");

            Clear();

            WriteLine(jenica.Attack(4));
            WriteLine(arus.Attack());
            WriteLine(rakish.Attack(10));

        }
    }
}