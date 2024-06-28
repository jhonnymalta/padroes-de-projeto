using FactoryMethod;

PersonagemFactory personagemFactory = new PersonagemFactory();

Console.WriteLine("Liu Kang | Scorpion | SubZero");
Console.WriteLine();
Console.Write("Escolha seu persongem");
Console.WriteLine();

string escolha = Console.ReadLine();


IPersonagem personagem = personagemFactory.EscolherPersonagem(escolha);
Console.WriteLine();
Console.WriteLine("Você vai jogar com ");
personagem.Escolhido();

Console.ReadKey();