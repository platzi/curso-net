string[] nombres= new string[4];
nombres[0] = "Oscar";
nombres[1] = "Felipe";
nombres[2] = "Amin";
nombres[3] = "Jorge";

Console.WriteLine("Los nombres de mi arreglo son: ");
foreach(string nombre in nombres)
{
    Console.WriteLine(nombre);
}

List<string> nombres2 = new List<string>();
nombres2.Add("Oscar");
nombres2.Add("Felipe"); 
nombres2.Add("Amin");
nombres2.Add("Jorge");

Console.WriteLine("Los nombres de mi lista son: ");
foreach(string nombre in nombres2)
{
    Console.WriteLine(nombre);
}