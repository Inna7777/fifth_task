// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] arr = new double[6];
void PrintArray(double[] arr)
{
Random rnd = new Random();


      for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*10;
        Console.Write($"{arr[i]:F2}, "); 
          
    }
      Console.WriteLine();
}

 double Diffmas(double[] array) 
 {   int i = 0;
     double Diff;
    double max = array[i];
    double min = array[i];
    foreach(double el in array)
    {
            if ( el > max)
            {
                max = el;
            } 
            else {
             if ( el < min) 
             {
                min = el;
             }
            }
     }
     Console.WriteLine($" {max:F2}");
     Console.WriteLine($" {min:F2}");
     Diff = max -min;
    return Diff ;
    
}
 
PrintArray(arr);
Console.WriteLine($"Разница = {Diffmas(arr):F2}");

