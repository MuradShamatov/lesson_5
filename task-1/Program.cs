//Задача 1: Создание строки из двумерного массива символов

string CreateString(char [,] array)
{
    string result = "";
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i,j];
        }
    } 
    return result;
}

char [,] array = new char [,]
{
    {'a', 's', 'f'},
    {'v', 'c', 'z'}
};

string result = CreateString(array);

Console.Write(result);