// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] arr = new double[4];
void PrintArray(double[] arr)
{ 
             for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()*10;
        Console.Write($"{arr[i]:F2}, "); 
          
    }
      Console.WriteLine();
}

 double MaxArr(double[] array) 
 {   int i = 0;
    double max = array[i];
    foreach(double el in array)
    {
            if ( max < el)
            {
                max = el;
            } 
             
     }
     Console.WriteLine($" {max:F2}");
    return max;
    
}
 double MinArr(double[] array) 
 {   int i = 0;
    double min = array[i];
    foreach(double el in array)
    {
            if ( min > el )
            {
                min = el;
            } 
              
     }
     Console.WriteLine($" {min:F2}");
   
    return min;
}
PrintArray(arr);
double Diff = MaxArr(arr) - MinArr(arr);
Console.WriteLine($"Разница = {Diff:F2}");