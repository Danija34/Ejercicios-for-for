Console.WriteLine("Se le mostrara una tabla de multiplicar del 1 al 5 en pantalla");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        int resultado = i * j;
    Console.Write("{0,4}",resultado);
    }
    Console.WriteLine();
}