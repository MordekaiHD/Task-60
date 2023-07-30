// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintIndex(int[,,] massive3D)
{
    for (int i = 0; i < massive3D.GetLength(0); i++)
    {
        for (int j = 0; j < massive3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < massive3D.GetLength(2); k++)
            {
                Console.Write($"{massive3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] Create3DMassive(int rows, int columns, int medium,int startValue, int finishValue)
{
    Console.WriteLine();
    Console.Write("Массив размером 2 x 2 x 2");
    
    int[,,] massive3D = new int[rows, columns, medium];
    for(int i = 0; i < massive3D.GetLength(0); i++)
    {
        for(int j = 0; j < massive3D.GetLength(1); j++)
        {
            for (int k = 0; k < massive3D.GetLength(2); k++)
            {
                massive3D[i, j, k] = new Random().Next(startValue, finishValue + 1);
            }
            
        }
    }
    return massive3D;
}
int[,,] massive3D = Create3DMassive(2, 2, 2, 10, 50);
PrintIndex(massive3D);