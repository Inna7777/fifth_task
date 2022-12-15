// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] arr = new int[6];
void PrintArray(int[] arr)
{
         for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99 , 99);
        Console.Write($"{arr[i]}, "); 
          
    }
      Console.WriteLine();
}


 int SumOdd(int[] array) 
 {   
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if ( (i % 2) == 0)
            {
                Sum = Sum + array[i];
            } 
           
     }
     Console.WriteLine($" Сумма чисел на нечетных позициях  {Sum}");
    return Sum;
    
}
 
PrintArray(arr);
SumOdd(arr);
Console.WriteLine();