int poäng = 5;
string val1;
//string val2;
//string val3;

// namn
Console.WriteLine("Vad heter du?");
Console.WriteLine("Svar :");

string name = Console.ReadLine();
//intro
Console.WriteLine("Välkommen " + name + " till programment Vem vill bli en Miljonär!");
Console.WriteLine($"Du börjar med {poäng} och för varje fråga du får rätt så får du 1 poäng när du når 10 poäng så vinner du ");
Console.WriteLine("Då börjar vi med första frågan.");


// första frågan

//bool keeplooping = true;
Console.WriteLine("Hur länge har varit Svampbob fyrkant varit i production och televiserat.");
Console.WriteLine("A = 1999 | B = 2000 | C = 2001");

//while (keeplooping)

val1 = Console.ReadLine();

if (val1.ToLower() == "a")
{
    Console.WriteLine($"Rätt svar");
}
else if (val1.ToLower() == "b")
{
    fel();   
}
else if (val1.ToLower() == "c")
{
    fel();
    
}
else 
{
    Console.WriteLine("Inte ett alternativ testa igen.");
    
}

Console.ReadLine();




static void fel()
{
    Console.WriteLine("""
  ______     _                                __
 |  ____|   | |                           _  / /
 | |__  ___ | |  ___ __   __ __ _  _ __  (_)| | 
 |  __|/ _ \| | / __|\ \ / // _` || '__|    | | 
 | |  |  __/| | \__ \ \ V /| (_| || |     _ | | 
 |_|   \___||_| |___/  \_/  \__,_||_|    (_)| | 
                                             \_\
 """);
}

