/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}


//метод инициализации массива
int[] InitArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100,100);
    }

    return array;
}

// метод нахождения максимального элемента массива

int Max (int [] array)
{
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max=array[i]; 
    }    
}   
    return max;
}

// метод нахождения минимального элемента массива

int Min (int [] array)
{
int min = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min=array[i]; 
    }    
}   
    return min;
}

//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int dimension = GetNumber ("Введите размерность массива");
int [] array = InitArray(dimension);
int max = Max (array);
int min = Min (array);

PrintArray(array);

Console.Write($"{(max-min)}");