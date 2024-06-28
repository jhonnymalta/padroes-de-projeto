

#region numero
using System.Threading.Channels;

string paragrafo = "Eu dei um passo a frente, busquei meu desejo de crescer e viver com a família";

var paragrafoMinusculo = paragrafo.ToLower();
var paragrafoSplit = paragrafo.Split(',');
var paragrafoReplace = paragrafo.Replace("busquei", "fui atrás");

var teste1 = paragrafo.IndexOf("dei");
var teste2 = paragrafo.LastIndexOf("viver");
var teste3 = paragrafo.StartsWith("viver");
var teste4 = paragrafo.Substring(teste1,7);


var number = new int[] { 0, 1, 2, 3, 4, 5 };
var number1 = new int[8];


var stringDeNumeros = "0,1,2,55,33,88,99,152";
var numerosArray = stringDeNumeros.Split(",");
var numerosConvertidosDaString = Array.ConvertAll(numerosArray, Convert.ToInt32);

var listNova = new List<int> { 0,1,2,3,4};
var listFromArray = new List<int>(numerosConvertidosDaString);

listNova.Add(5);
listNova.Add(9);
listNova.AddRange(listFromArray);
listNova.AddRange(new int[] { 16, 177 });

var count = listNova.Count;
var contains14 = listNova.Contains(14);
var contains2 = listNova.Contains(2);
listNova.Reverse();
Console.WriteLine(listNova);
listNova.ForEach(n => Console.WriteLine(n));
listNova.Sort();
Console.WriteLine(listNova);
listNova.Remove(2);
Console.WriteLine(listNova);
listNova.RemoveAll(l => l > 90);
Console.WriteLine(listNova);
listNova.Clear();



Console.WriteLine(listNova);

#endregion


var estudantes = new List<Estudante>()
{
    new Estudante(1,"Maria","123","3b"),
    new Estudante(1,"Maria","123","3b"),
    new Estudante(1,"Maria","123","3b")
};


var folderName = "pasta";
var subFolderName = "subpasta";
var subFolderNameStatic = "subpasta_usingstatic";

var directoryInfoSubFolder = new DirectoryInfo(folderName);

if(!Directory.Exists(folderName) || !directoryInfoSubFolder.Exists)
{
    Directory.CreateDirectory(subFolderNameStatic);
    Directory.CreateDirectory(folderName);
    directoryInfoSubFolder.Create();

    directoryInfoSubFolder.MoveTo(@$"{folderName}\{subFolderName}");
    Directory.Move(subFolderNameStatic, @$"{folderName}\{subFolderNameStatic}");
}

var name = directoryInfoSubFolder.Name;
var parent = directoryInfoSubFolder.Parent;
var root = directoryInfoSubFolder.Root;
var exists = directoryInfoSubFolder.Exists;

foreach(var directory in Directory.GetDirectories(folderName))
{
    Console.WriteLine(directory);
}

var file = @"pasta\texto.txt";
if (!File.Exists(file))
{
    File.CreateText(file);
}
var fileInfo = new FileInfo(file);
Console.WriteLine(fileInfo);

Directory.Delete($@"{folderName}\{subFolderName}");

public class Estudante
{
    public Estudante(int id, string nome,string registro,string classe )
    {
        Id = id;
        Nome = nome;
        Registro = registro;
        Classe = classe;
        Telefones = new List<string> { "31999328177", "31999257899", "3199966332255" };
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Registro { get; set; }
    public string Classe { get; set; }
    public List<string> Telefones { get; set; }
}

