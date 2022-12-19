/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
(В примерах к задаче ошибка- там сумма элементов, стоящих на четных позициях)

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

// метод подсчета суммы чисел, удовлетворяющих условию

int SumDigits (int [] array)
{
int sum = 0;

for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)

            {
                sum +=array[i]; 
            }      
    }  
    return sum;
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

Console.WriteLine($"{SumDigits(array)}");

