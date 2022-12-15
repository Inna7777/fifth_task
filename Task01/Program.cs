//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу,которая покажет количество чётных чисел в массиве.
int[] arr = new int[10];
void PrintArray(int[] arr)
{
         for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100 , 999);
        Console.Write($"{arr[i]}, "); 
          
    }
      Console.WriteLine();
}


 int EventNum(int[] arr) 
 {   
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if ( (arr[i] % 2) == 0)
            {
                count++;
                Console.Write(arr[i]+",");
            } 
             
     }
     Console.WriteLine($"  Четных чисел {count}");
    return count;
    
}
 
PrintArray(arr);
EventNum(arr);
Console.WriteLine();
