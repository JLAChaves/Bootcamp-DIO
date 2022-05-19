using DIO___Projeto_RPG.Entities;

Knight knight = new Knight("Arus", 42, "Knight", 749, 72);
Ninja ninja = new Ninja("Wedge", 42, "Ninja", 574, 89);
Wizard wizard = new Wizard("Jennica", 42, "White Wizard", 601, 482);
Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 385, 641);

Console.WriteLine(knight);
Console.WriteLine(ninja);
Console.WriteLine(wizard);
Console.WriteLine(blackWizard);

Console.WriteLine(knight.Attack(4));
Console.WriteLine(ninja.Attack(7));
Console.WriteLine(wizard.Attack(8));
Console.WriteLine(blackWizard.Attack(2));

