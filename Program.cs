/*
Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
*/
//Параметризация (добавление аргументов)
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1>=0 && row1 < array.GetLength(0) && 
    row2>=0 && row2 < array.GetLength(0) && 
    row1!=row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1,j]=array[row2,j];
            array[row2,j]=temp;
        }
    }

}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

Console.WriteLine();

Console.Write("Input a number of first row for change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of seconf row for change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);
*/

/*
Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы.
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] CheckSize(int[,] array)
{
    if(array.GetLength(0)==array.GetLength(1))
    {
        for(int i=0; i<array.GetLength(0)-1; i++)
        {    
            for(int j=i+1; j<array.GetLength(1); j++)
            {
                int temp=array[i,j];
                array[i,j]=array[j,i];
                array[j,i]=temp;
            }
        }
    }
    return array;
}


int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

CheckSize(myArray);
Console.WriteLine();
Show2dArray(myArray);

/*
Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

int[] FindMin(int[,] array)
{

        int min = array[0,0];
        int minRow = 0;
        int minCol = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j] < min) 
            min=array[i,j];
            minRow = i;
            minCol = j;
        }
    }
    int[] minArray = {minRow,minCol};
    return minArray;
}

int[,]Copy (int[] minArray, int[,] array)
{   int n = 0;
    int m = 0;
    int[,] newArray = new int [rows, columns];
    for(int i = 0;i < array.GetLength(0); i++)
    {   if(i!=minArray[0])
            for(int j = 0; j < array.GetLength(1); j++)
            {
            if(j!=minArray[1])
            {
                newArray[]
            }
            }
    }
    return newArray;
}


Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

int[] IndexOfMin(int[,] array)
{
    int[] coordinates = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    return coordinates;
}

/*void ChangeToZero(int[,] array, int[] coordinates)
{
    for (int i = coordinates[0], j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
    for (int j = coordinates[1], i = 0; i < array.GetLength(0); i++)
        array[i, j] = 0;
}*/

/*int[,] DeletedRowsColumns (int[,]array, int[] coordinates)
{
    int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0, m=0; i < array.GetLength(0); i++, m++)
    {
        if (i != coordinates[0])
            for (int j=0, l=0; j<array.GetLength(1); j++, l++)
            {
                if (j != coordinates[1]) newArray[m,l] = array[i,j];
                else l--;
            }
        else m--;
    }
return newArray;
}

int [,] firstArray = CreateRandom2dArray (rows, col, min, max);
Show2dArray (firstArray);
int [] coord = IndexOfMin (firstArray);
int[,] result = DeletedRowsColumns (firstArray, coord);
Show2dArray (result);*/
