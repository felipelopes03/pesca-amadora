int mar;
int peso;


Console.WriteLine("== Pesca Amadora ==");
Console.WriteLine("Você esta em águas continentais e estuarinas");
Console.WriteLine("Digite 1 para continuar");
mar= Convert.ToInt32(Console.ReadLine());

        if(mar == 1)
        {
            Console.WriteLine("Você esta em águas continentais e estuarinas. Insira o Kg do peixe:");
           peso = Convert.ToInt32(Console.ReadLine());

        if (peso > 10 )
        {
            Console.ForegroundColor = ConsoleColor . Red;
            Console.WriteLine("Pescaria excede os limites legais em águas continentais e estuarinas de 10kg. Sujeito a multa de R$ 1000,00., com acréscimo de R$20,00 por quilo excedido.");
            int multa = 1000 + (20 * (peso - 10));
            Console.WriteLine($"Sujeito a multa de R$: {multa}");
            Console.ResetColor();
        }

        else 
        { 
            Console.ForegroundColor = ConsoleColor . Blue;
            Console.WriteLine("Pescaria dentro dos limites legais");
            Console.ResetColor();
        }
        }
   
        else if (mar == 2)
        {
            Console.WriteLine("Você esta em águas marinhas. Insira a quantidade em kg do peixe:");
            peso = Convert.ToInt32(Console.ReadLine());

        if (peso > 15)
        {
            Console.ForegroundColor = ConsoleColor . Red;
            Console.WriteLine("Pescaria excede os limites legais em águas marinhas de 15kg. Sujeito a multa de R$ 1000,00.");
            int multa = 1000 + (20 * (peso - 15));
            Console.WriteLine($"Sujeito a multa de R$: {multa}");
            Console.ResetColor();
        }

        else 
        { 
            Console.ForegroundColor = ConsoleColor . Blue;
            Console.WriteLine("Pescaria dentro dos limites legais");
            Console.ResetColor();
        }
        }