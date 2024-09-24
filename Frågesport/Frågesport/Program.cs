    static void Main(string[] args)
    {
        int poäng = 0;
        string val1;
        string name;

        // Namn
        Console.WriteLine("Vad heter du?");
        Console.WriteLine("Svar:");
        name = Console.ReadLine();

        // Intro
        Console.WriteLine($"Välkommen {name} till programmet Vem vill bli en Miljonär!");
        Console.WriteLine("För varje fråga du får rätt så får du 1 poäng. När du når 3 poäng har du vunnit!");
        Console.WriteLine("Då börjar vi med första frågan.");

        // Första frågan
        Console.WriteLine("Hur länge har Svampbob Fyrkant varit i produktion och tv-sänts?");
        Console.WriteLine("A = 1999 | B = 2000 | C = 2001");
        val1 = Console.ReadLine();

        if (val1.ToLower() == "a")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            fel();
        }

        // Andra frågan
        Console.WriteLine("Vilken är huvudstaden i Frankrike?");
        Console.WriteLine("A = London | B = Berlin | C = Paris");
        val1 = Console.ReadLine();

        if (val1.ToLower() == "c")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            fel();
        }

        // Tredje frågan
        Console.WriteLine("Vilken planet är närmast solen?");
        Console.WriteLine("A = Venus | B = Merkurius | C = Mars");
        val1 = Console.ReadLine();

        if (val1.ToLower() == "b")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            fel();
        }

        // Resultat och avslutning
        Console.WriteLine($"Du fick {poäng} poäng!");

        if (poäng == 3)
        {
            Console.WriteLine("Fantastiskt! Du är en mästare!");
        }
        else if (poäng == 2)
        {
            Console.WriteLine("Bra jobbat! Nästan full pott!");
        }
        else if (poäng == 1)
        {
            Console.WriteLine("Du fick ett rätt. Fortsätt träna!");
        }
        else
        {
            Console.WriteLine("Tyvärr inga rätt. Bättre lycka nästa gång!");
        }

        Console.ReadLine();
    }

    static void fel()
    {
        Console.WriteLine(@"  
  ______     _                                __
 |  ____|   | |                           _  / /
 | |__  ___ | |  ___ __   __ __ _  _ __  (_)| |
 |  __|/ _ \| | / __|\ \ / // _` || '__|    | |
 | |  |  __/| | \__ \ \ V /| (_| || |     _ | |
 |_|   \___||_| |___/  \_/  \__,_||_|    (_)| |
                                             \_\
        ");
    }
