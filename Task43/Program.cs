// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine($"\nДанная программа находит точку пересечения двух прямых, коэффициенты для которых задаются пользователем.\n");

double[,] coef = new double[2, 2];
double[] crossPoint = new double[2];

void EnterCoefficients()
{
  for (int i = 0; i < coef.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coef.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coef[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Setting(double[,] coef)
{
  crossPoint[0] = (coef[1,1] - coef[0,1]) / (coef[0,0] - coef[1,0]);
  crossPoint[1] = crossPoint[0] * coef[0,0] + coef[0,1];
  return crossPoint;
}

void Finding(double[,] coef)
{
  if (coef[0,0] == coef[1,0] && coef[0,1] == coef[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coef[0,0] == coef[1,0] && coef[0,1] != coef[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Setting(coef);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})\n");
  }
}

EnterCoefficients();
Finding(coef);
Console.WriteLine();
