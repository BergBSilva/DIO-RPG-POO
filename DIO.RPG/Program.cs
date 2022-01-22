using DIO.RPG.src.Entities;
using static System.Console;

Knight arus = new Knight("Arus", 100, 1, "Knight");
Wizard aamon = new Wizard("Aamon ", 60, 1, "Wizard");
Thief erik = new Thief("Erik", 80, 1, "Thief");

WriteLine("######################## DRAGON QUEST ##############################");

WriteLine($@"Ataque do {arus.Name}");
WriteLine($@"{arus.Attack()}");
WriteLine($@"{arus.Attack(4)}");
WriteLine($@"{arus.Attack(8)}");

WriteLine("\n");

WriteLine($@"Ataque do {aamon.Name}");
WriteLine($@"{aamon.Attack()}");
WriteLine($@"{aamon.Attack(4)}");
WriteLine($@"{aamon.Attack(8)}");

WriteLine("\n");

WriteLine($@"Ataque do {erik.Name}");
WriteLine($@"{erik.Attack()}");
WriteLine($@"{erik.Attack(4)}");
WriteLine($@"{erik.Attack(8)}");

