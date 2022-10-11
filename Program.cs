// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to DnDHelper 0.1");
Console.WriteLine("Insert character name: ");
string? name = null;
name = Console.ReadLine();
Console.WriteLine($"Character: {name}");

FileInfo char_file = new FileInfo("C:/Users/StefanoSavarino/Desktop/characters.txt");
StreamWriter sw = char_file.CreateText();
sw.WriteLine("character: " + name);
sw.Close();
