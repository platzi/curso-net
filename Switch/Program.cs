List<string> nombres2 = new List<string>();
nombres2.Add("Oscar");
nombres2.Add("Felipe"); 
nombres2.Add("Amin");
nombres2.Add("Jorge");

switch (nombres2[3])
{
    case "Oscar":
        Console.WriteLine("El nombre es Oscar");
        break;
    case "Felipe":
        Console.WriteLine("El nombre es Felipe");
        break;
    case "Amin":
        Console.WriteLine("El nombre es Amin");
        break;
    case "Jorge":
        Console.WriteLine("El nombre es Jorge");
        break;
    default:
        Console.WriteLine("No se encontró el nombre");
        break;
}