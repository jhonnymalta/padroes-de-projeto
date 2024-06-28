using AbstractFactory;

IFrabricaDeBase fabrica;
Console.WriteLine("Escolha um tipo de personagem: ");
Console.WriteLine("1 - Protos");
Console.WriteLine("2 - Terrenos");
Console.WriteLine("3 - Zergs");
switch (Console.ReadLine())
{
    case "1":
        fabrica = new FabricaDeBaseProtos();
        break;
    case "2":
        fabrica = new FabricaDeBaseTerranos();
        break;
    case "3":
        fabrica = new FabricaDeBaseZergs();
        break;
}
Console.ReadLine();

