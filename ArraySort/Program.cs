// заданный массив 
int[,] arr = new int[,] { { 7, 3, 2 }, { 4, 9, 6 }, { 8, 1, 5 } };

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        { Console.Write(arr[i, j] + " "); }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[,] arr)
{

    int temp = arr[0, 0];
    for (int g = 0; g < (arr.GetLength(0) + 1) * (arr.GetLength(0) + 1) - 1; g++)
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {

                // проверка разницы по строкам
                if (i < arr.GetLength(0)-1)
                {
                    if (arr[i, arr.GetLength(1)-1] > arr[i + 1, 0])
                    {
                        temp = arr[i, arr.GetLength(1)-1];
                        arr[i, arr.GetLength(1) - 1] = arr[i + 1, 0];
                        arr[i + 1, 0] = temp;
                    }
                }

                // проверка разницы внутри одномерного подмассива
                if (arr[i, j] > arr[i, j + 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }

            }

        }
    }
}


    Print(arr);
SortArray(arr);
    Print(arr);



