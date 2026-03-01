Console.WriteLine("Se le mostrara una tabla de 4x4");
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
    Console.Write("{0,5}",i+",",+j);
    }
    Console.WriteLine();
}