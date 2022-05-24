Console.WriteLine("Ingrese fila ");
int fila = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese columna ");
int columna = int.Parse(Console.ReadLine());
int[,] numeros = new int[fila, columna];
double[] promedios = new double[columna];
double acumulador = 0;
double contador = 0;
for (int f = 0; f < fila; f++)
{
    //agregar items
    for (int c = 0; c < columna; c++)
    {
        Console.WriteLine($"ingrese elemento [{f},{c}]:");
        numeros[f, c] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Clear();
Console.WriteLine("--------------");
Console.WriteLine("(fila,columna)");
//bucle para mostrar 
for (int f = 0; f < fila; f++)
{
    //mostrar items
    for (int c = 0; c < columna; c++)
    {
        Console.WriteLine($"\n({f},{c})={numeros[f, c]}");
    }
}
//bucle que recorra columna , recorrre la fila suma los eleemntos y luego los divide para pro fin agregarlo al array promedio.
for (int c = 0; c < columna; c++)
{
    for (int f = 0; f < fila; f++)
    {
        acumulador=acumulador+Convert.ToDouble(numeros[f, c]);
        contador++;
    }
    promedios[c] = (acumulador / contador);
    contador = 0;
    acumulador = 0;
}
Console.WriteLine("\nPROMEDIOS");
Console.WriteLine("--------------");
foreach (double elemento in promedios)
{
    Console.WriteLine($"columna:{contador}\t {elemento}");
    contador++;
}