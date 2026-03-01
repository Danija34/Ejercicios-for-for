Console.WriteLine("Se le mostrara una matriz de 3x3 con numeros consecutivos del 1 al 9 en pantalla");
int contador = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
    Console.Write("{0,3}",contador);
        contador++;
    }
    Console.WriteLine();
}