/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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
        array[i] = rnd.Next(100,999);
    }

    return array;
}

// метод подсчета количества элементов, удовлетворяющих условию

int CountNumbers (int [] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
            {
                count++; 
            }
    }       
    return count;
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
PrintArray(array);

Console.WriteLine($"Количество четных чисел в массиве составляет {CountNumbers(array)}");

