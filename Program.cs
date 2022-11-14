/*****************************************************************************/
/* C# program to learn the language                                          */
/* The initial idea is to store character sheets and DnD info in it.         */
/*                                                                           */
/* TODO:                                                                     */
/*  - add database integration to store character sheets, NPCs, and more     */
/*                                                                           */
/*****************************************************************************/


using System;
using System.Security.Cryptography.X509Certificates;

class DnDHelper {

    internal class CharacterStats
    {
        private string name;
        private int hp;

        public CharacterStats(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            Console.WriteLine("CharacterStats class created!");
        }

        // properties definition
        public string Name => name;
        public int Hp => hp;
    }

    static void Main()
    {
        Stack<CharacterStats> stats = new Stack<CharacterStats>();
        Console.WriteLine("Welcome to DnDHelper 0.1");
        
        // poll user for name
        Console.WriteLine("Insert character name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Character name: {name}");

        // poll user for hp
        Console.WriteLine("Insert character hp: ");
        string? hp_string = Console.ReadLine();
        int hp = 0;
        hp = Int32.Parse(hp_string);
        Console.WriteLine($"Character hp: {hp}");

        // create character stat
        var char1 = new CharacterStats(name, hp);

        stats.Push(char1);

        // extract item from stack
        CharacterStats printable = stats.Pop();

        // open new file
        FileInfo char_file = new FileInfo("C:/Users/StefanoSavarino/Desktop/characters.txt");
        StreamWriter sw = char_file.CreateText();

        sw.WriteLine("character name: " + printable.Name);
        sw.WriteLine("character hp: " +printable.Hp);
        sw.Close();
    }
}