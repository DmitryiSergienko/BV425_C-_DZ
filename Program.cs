// Вариант 3: Заполнение матрицы змейкой по диагонали
int Y = 4;
int X = 5;
int[,] matrix = new int[Y, X];

int minSize = Y;
int maxSize = X;
if (X < Y)
{
    minSize = X;
    maxSize = Y;
}
int firstLastDiag = minSize - 1;

int iter = X * Y;
int iter2 = iter;
int shiftRight = 0;
int shiftLeft = 0;

for (int i = 0; i < Y + X - 1; i++) // Количество диагоналей
{
    if (i >= X)
    {
        shiftRight++;
    }
    if (i >= Y)
    {
        shiftLeft++;
    }
    for (int j = 0; j < minSize - firstLastDiag; j++) // Длина диагонали
    {
        if (i % 2 == 1)
        {
            matrix[j + shiftRight, i - j - shiftRight] = iter;
            //Console.Write(matrix[j + shiftRight, i - j - shiftRight]);
        }
        else
        {
            matrix[i - j - shiftLeft, j + shiftLeft] = iter;
            //Console.Write(matrix[i - j - shiftLeft, j + shiftLeft]);
        }
        iter--;
        iter2--;

        for (int y = 0; y < Y; y++)
        {
            for (int x = 0; x < X; x++)
            {
                if (matrix[y, x] == 0)
                {
                    break;
                }
                Console.Write(matrix[y, x] - iter2 + "\t");
            }
            Console.WriteLine();
        }
        Thread.Sleep(500);
        Console.Clear();
    }
    //Console.WriteLine();

    if (i < minSize - 1) // Нарщиваем диагональ
    {
        firstLastDiag--;
    }
    else if (i > maxSize - 2) // Уменьшаем диагональ
    {
        firstLastDiag++;
    }
}

//Console.WriteLine();
for (int i = 0; i < Y; i++)
{
    for (int j = 0; j < X; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}