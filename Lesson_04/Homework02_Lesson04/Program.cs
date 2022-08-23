// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = new double[10];
  for (int i = 0; i < arr.Length; i++ )
  {
    arr[i] = new Random().Next(1, 10);
    Console.Write(arr[i] + " ");
  }

double maxNumber = arr[0];
double minNumber = arr[0];

  for (int i = 1; i < arr.Length; i++)
  {
    if (maxNumber < arr[i])
    {
      maxNumber = arr[i];
    }
        if (minNumber > arr[i])
    {
      minNumber = arr[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");