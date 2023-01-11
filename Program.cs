void FillArrayString(string[]massiv)
{
    int length = massiv.Length;
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        massiv[i] = Console.ReadLine();
    }
}
