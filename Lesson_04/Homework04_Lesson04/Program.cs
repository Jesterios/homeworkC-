// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] cf = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < cf.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < cf.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      cf[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] cf)
{
  crossPoint[0] = (cf[1,1] - cf[0,1]) / (cf[0,0] - cf[1,0]);
  crossPoint[1] = crossPoint[0] * cf[0,0] + cf[0,1];
  return crossPoint;
}

void OutputResponse(double[,] cf)
{
  if (cf[0,0] == cf[1,0] && cf[0,1] == cf[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (cf[0,0] == cf[1,0] && cf[0,1] != cf[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(cf);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(cf);