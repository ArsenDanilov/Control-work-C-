void FillArrayString(string[]massiv)
{
    int length = massiv.Length;
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        massiv[i] = Console.ReadLine();
    }
}

void PrintArrayString(string[]massiv)
{
    int length = massiv.Length;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Вывод первоначального массива: ");
    for (int i = 0; i < massiv.Length; i++)
    {
         Console.Write(massiv[i] + "  ");
    }
}


