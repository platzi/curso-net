List<string> listaNombres = new List<string>();
List<string> listaApellidos = new List<string>();

listaNombres.Add("Juan");
listaNombres.Add("Pedro");
listaNombres.Add("Maria");
listaNombres.Add("Ana");
listaNombres.Add("Luis");

listaApellidos.Add("Gomez");
listaApellidos.Add("Lopez");
listaApellidos.Add("Martinez");
listaApellidos.Add("Hernandez");
listaApellidos.Add("Garcia");

foreach (string nombre in listaNombres)
{
    foreach (string apellido in listaApellidos)
    {
        Console.WriteLine($"{nombre} {apellido}");
    }
}