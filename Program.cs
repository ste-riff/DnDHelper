using System;
class DnDHelper {

    class CharacterStats
    {
        string name;
        int hp;

        public CharacterStats(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            Console.WriteLine("CharacterStats class created!");
        }
        
        public string getName()
        {
            return name;
        }
        public int getHp()
        {
            return hp;
        }
    }
    Stack<CharacterStats> stats;
    static void Main()
    {
        var stats = new Stack<CharacterStats>();
        Console.WriteLine("Welcome to DnDHelper 0.1");
        
        // poll user for name
        Console.WriteLine("Insert character name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Character name: {name}");

        // poll user for hp
        Console.WriteLine("Insert character hp: ");
        string hp_string = Console.ReadLine();
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

        sw.WriteLine("character name: " + printable.getName());
        sw.WriteLine("character hp: " +printable.getHp());
        sw.Close();
    }
}