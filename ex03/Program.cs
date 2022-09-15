
Console.Clear();

void PrintArryaMatrix(int[,] argMatrix)   // Метод вывода матрицы
{
    for (int i = 0; i < argMatrix.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < argMatrix.GetLength(1); j++)  // columns - столбцы
        {
            Console.Write($"{argMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArryaMatrix(int[,] argMatrix)
{
      for (int i = 0; i < argMatrix.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < argMatrix.GetLength(1); j++)  // columns - столбцы
        {
            argMatrix[i,j]=new Random().Next(1,10);
        }
    }
}

int[,] arrMatrix = new int[3, 4];

PrintArryaMatrix(arrMatrix);
FillArryaMatrix(arrMatrix);
Console.WriteLine();
PrintArryaMatrix(arrMatrix);