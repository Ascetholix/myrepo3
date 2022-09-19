
Console.Clear();
//    void Obj(int[,] arg, int sn)
// {
//     int n = 0;
//     if (sn == 1)
//     {

//         arg[3, 2] = 1;
//         arg[4, 2] = 1;
//         arg[4, 3] = 1;
//         arg[5, 2] = 1;
//     }
//     else if (sn == 2)
//     {

//         arg[3, 2] = 1;
//         arg[3, 3] = 1;
//         arg[4, 3] = 1;
//         arg[3, 4] = 1;
//     }
//     else if (sn == 3)
//     {

//         arg[3, 2] = 1;
//         arg[3, 3] = 1;
//         arg[4, 3] = 1;
//         arg[2, 3] = 1;
//     }
//     else if (sn == 4)
//     {
//         n = 1;
//         arg[3 - n, 2] = 1;
//         arg[4 - n, 2] = 1;
//         arg[4 - n, 3] = 1;
//         arg[5 - n, 2] = 1;
//     }
//     else
//     {
//         arg[3, 2] = 1;
//         arg[4, 2] = 1;
//         arg[4, 3] = 1;
//         arg[5, 2] = 1;
//     }
// }

void Obj(int[,] arg, int sn)
{
    if (sn == 1) arg[3, 2 + sn] = 1;
}

int N = 0;
int exit = 0;
while (exit != 10)
{
    int[,] tetris = new int[,]
    {
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
{2, 0, 0, 0, 0, 0, 0, 0, 2 },
    };

    void PrintArrya(int[,] argImage)   // Метод вывода матрицы
    {
        for (int i = 0; i < argImage.GetLength(0); i++) // rows - строки
        {
            for (int j = 0; j < argImage.GetLength(1); j++)  // columns - столбцы
            {
                if (argImage[i, j] == 2) Console.Write("|");
                if (argImage[i, j] == 1) Console.Write("▓");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    int EntCommand()
    {
        Console.Write("Для выхода 10. 1 - право, 2 -лево, 3 вниз, 4 - вверх: ");
        return N = Convert.ToInt32(Console.ReadLine());
    }

    EntCommand();
    Obj(tetris, N);
    Console.Clear();

    PrintArrya(tetris);

    exit = N;
}